FROM mcr.microsoft.com/dotnet/sdk:6.0
WORKDIR /app

ARG BATTLENETACCOUNTID
ARG BATTLENETPROFILEID
ARG CLIENT_ID
ARG CLIENT_SECRET
ARG DRONE_BRANCH
ARG SONAR_HOST
ARG SONAR_TOKEN

# Install sonarScanner
RUN dotnet tool install --global dotnet-sonarscanner
ENV DOTNET_ROLL_FORWARD=Major
ENV PATH="${PATH}:/root/.dotnet/tools"

# Install sonarScanner dependencies
RUN apt-get update
# Next line fix openjdk11 install
RUN mkdir -p /usr/share/man/man1
RUN apt install openjdk-11-jdk jq -y
RUN curl -sL https://deb.nodesource.com/setup_16.x | bash -
RUN apt-get install -y nodejs

# Build Project
COPY . ./

RUN jq ".CLIENT_SECRET = \"$CLIENT_SECRET\"" Dysnomia.Common.BlizzardWebAPI.Test/appsettings.json > tmp.appsettings.json && mv tmp.appsettings.json Dysnomia.Common.BlizzardWebAPI.Test/appsettings.json
RUN jq ".CLIENT_ID = \"$CLIENT_ID\"" Dysnomia.Common.BlizzardWebAPI.Test/appsettings.json > tmp.appsettings.json && mv tmp.appsettings.json Dysnomia.Common.BlizzardWebAPI.Test/appsettings.json
RUN jq ".BattleNetAccountId = \"$BATTLENETACCOUNTID\"" Dysnomia.Common.BlizzardWebAPI.Test/appsettings.json > tmp.appsettings.json && mv tmp.appsettings.json Dysnomia.Common.BlizzardWebAPI.Test/appsettings.json
RUN jq ".BattleNetProfileId = \"$BATTLENETPROFILEID\"" Dysnomia.Common.BlizzardWebAPI.Test/appsettings.json > tmp.appsettings.json && mv tmp.appsettings.json Dysnomia.Common.BlizzardWebAPI.Test/appsettings.json

RUN dotnet sonarscanner begin /k:"dysnomia-common-blizzardwebapi" /d:sonar.host.url="$SONAR_HOST" /d:sonar.login="$SONAR_TOKEN" /d:sonar.cs.opencover.reportsPaths="**/coverage.opencover.xml" /d:sonar.coverage.exclusions="**Test*.cs" /d:sonar.branch.name="$DRONE_BRANCH"
RUN dotnet restore Dysnomia.Common.BlizzardWebAPI.sln --ignore-failed-sources /p:EnableDefaultItems=false
RUN dotnet build Dysnomia.Common.BlizzardWebAPI.sln /m:1 --no-restore -c Release -o out
RUN dotnet test /p:CollectCoverage=true /p:CoverletOutputFormat=opencover
RUN dotnet sonarscanner end /d:sonar.login="$SONAR_TOKEN"