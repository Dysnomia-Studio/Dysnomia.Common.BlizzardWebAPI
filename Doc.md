<a name='assembly'></a>
# Dysnomia.Common.BlizzardWebAPI

## Contents

- [ILegacyStarcraftCommunity](#T-Dysnomia-Common-BlizzardWebAPI-ILegacyStarcraftCommunity 'Dysnomia.Common.BlizzardWebAPI.ILegacyStarcraftCommunity')
  - [GetPlayerProfile(accessToken,region,regionId,realmId,profileId)](#M-Dysnomia-Common-BlizzardWebAPI-ILegacyStarcraftCommunity-GetPlayerProfile-System-String,System-String,System-Int32,System-Int32,System-UInt64- 'Dysnomia.Common.BlizzardWebAPI.ILegacyStarcraftCommunity.GetPlayerProfile(System.String,System.String,System.Int32,System.Int32,System.UInt64)')
  - [GetPlayerProfile(accessToken,region,regionId,realmId,profileId)](#M-Dysnomia-Common-BlizzardWebAPI-ILegacyStarcraftCommunity-GetPlayerProfile-System-String,Dysnomia-Common-BlizzardWebAPI-Enums-RegionEnum,Dysnomia-Common-BlizzardWebAPI-Enums-StarCraft2RegionEnum,Dysnomia-Common-BlizzardWebAPI-Enums-StarCraft2RealmEnum,System-UInt64- 'Dysnomia.Common.BlizzardWebAPI.ILegacyStarcraftCommunity.GetPlayerProfile(System.String,Dysnomia.Common.BlizzardWebAPI.Enums.RegionEnum,Dysnomia.Common.BlizzardWebAPI.Enums.StarCraft2RegionEnum,Dysnomia.Common.BlizzardWebAPI.Enums.StarCraft2RealmEnum,System.UInt64)')
- [IStarcraftCommunity](#T-Dysnomia-Common-BlizzardWebAPI-IStarcraftCommunity 'Dysnomia.Common.BlizzardWebAPI.IStarcraftCommunity')
  - [GetMetadataProfile(accessToken,region,regionId,realmId,profileId,locale)](#M-Dysnomia-Common-BlizzardWebAPI-IStarcraftCommunity-GetMetadataProfile-System-String,System-String,System-Int32,System-Int32,System-UInt64,System-String- 'Dysnomia.Common.BlizzardWebAPI.IStarcraftCommunity.GetMetadataProfile(System.String,System.String,System.Int32,System.Int32,System.UInt64,System.String)')
  - [GetMetadataProfile(accessToken,region,regionId,realmId,profileId,locale)](#M-Dysnomia-Common-BlizzardWebAPI-IStarcraftCommunity-GetMetadataProfile-System-String,Dysnomia-Common-BlizzardWebAPI-Enums-RegionEnum,Dysnomia-Common-BlizzardWebAPI-Enums-StarCraft2RegionEnum,Dysnomia-Common-BlizzardWebAPI-Enums-StarCraft2RealmEnum,System-UInt64,System-String- 'Dysnomia.Common.BlizzardWebAPI.IStarcraftCommunity.GetMetadataProfile(System.String,Dysnomia.Common.BlizzardWebAPI.Enums.RegionEnum,Dysnomia.Common.BlizzardWebAPI.Enums.StarCraft2RegionEnum,Dysnomia.Common.BlizzardWebAPI.Enums.StarCraft2RealmEnum,System.UInt64,System.String)')
  - [GetProfile(accessToken,region,regionId,realmId,profileId,locale)](#M-Dysnomia-Common-BlizzardWebAPI-IStarcraftCommunity-GetProfile-System-String,System-String,System-Int32,System-Int32,System-UInt64,System-String- 'Dysnomia.Common.BlizzardWebAPI.IStarcraftCommunity.GetProfile(System.String,System.String,System.Int32,System.Int32,System.UInt64,System.String)')
  - [GetProfile(accessToken,region,regionId,realmId,profileId,locale)](#M-Dysnomia-Common-BlizzardWebAPI-IStarcraftCommunity-GetProfile-System-String,Dysnomia-Common-BlizzardWebAPI-Enums-RegionEnum,Dysnomia-Common-BlizzardWebAPI-Enums-StarCraft2RegionEnum,Dysnomia-Common-BlizzardWebAPI-Enums-StarCraft2RealmEnum,System-UInt64,System-String- 'Dysnomia.Common.BlizzardWebAPI.IStarcraftCommunity.GetProfile(System.String,Dysnomia.Common.BlizzardWebAPI.Enums.RegionEnum,Dysnomia.Common.BlizzardWebAPI.Enums.StarCraft2RegionEnum,Dysnomia.Common.BlizzardWebAPI.Enums.StarCraft2RealmEnum,System.UInt64,System.String)')
  - [GetProfileLadder(accessToken,region,regionId,realmId,profileId,ladderId,locale)](#M-Dysnomia-Common-BlizzardWebAPI-IStarcraftCommunity-GetProfileLadder-System-String,System-String,System-Int32,System-Int32,System-UInt64,System-Int32,System-String- 'Dysnomia.Common.BlizzardWebAPI.IStarcraftCommunity.GetProfileLadder(System.String,System.String,System.Int32,System.Int32,System.UInt64,System.Int32,System.String)')
  - [GetProfileLadder(accessToken,region,regionId,realmId,profileId,ladderId,locale)](#M-Dysnomia-Common-BlizzardWebAPI-IStarcraftCommunity-GetProfileLadder-System-String,Dysnomia-Common-BlizzardWebAPI-Enums-RegionEnum,Dysnomia-Common-BlizzardWebAPI-Enums-StarCraft2RegionEnum,Dysnomia-Common-BlizzardWebAPI-Enums-StarCraft2RealmEnum,System-UInt64,System-Int32,System-String- 'Dysnomia.Common.BlizzardWebAPI.IStarcraftCommunity.GetProfileLadder(System.String,Dysnomia.Common.BlizzardWebAPI.Enums.RegionEnum,Dysnomia.Common.BlizzardWebAPI.Enums.StarCraft2RegionEnum,Dysnomia.Common.BlizzardWebAPI.Enums.StarCraft2RealmEnum,System.UInt64,System.Int32,System.String)')
  - [GetProfileLadderSummary(accessToken,region,regionId,realmId,profileId,locale)](#M-Dysnomia-Common-BlizzardWebAPI-IStarcraftCommunity-GetProfileLadderSummary-System-String,System-String,System-Int32,System-Int32,System-UInt64,System-String- 'Dysnomia.Common.BlizzardWebAPI.IStarcraftCommunity.GetProfileLadderSummary(System.String,System.String,System.Int32,System.Int32,System.UInt64,System.String)')
  - [GetProfileLadderSummary(accessToken,region,regionId,realmId,profileId,locale)](#M-Dysnomia-Common-BlizzardWebAPI-IStarcraftCommunity-GetProfileLadderSummary-System-String,Dysnomia-Common-BlizzardWebAPI-Enums-RegionEnum,Dysnomia-Common-BlizzardWebAPI-Enums-StarCraft2RegionEnum,Dysnomia-Common-BlizzardWebAPI-Enums-StarCraft2RealmEnum,System-UInt64,System-String- 'Dysnomia.Common.BlizzardWebAPI.IStarcraftCommunity.GetProfileLadderSummary(System.String,Dysnomia.Common.BlizzardWebAPI.Enums.RegionEnum,Dysnomia.Common.BlizzardWebAPI.Enums.StarCraft2RegionEnum,Dysnomia.Common.BlizzardWebAPI.Enums.StarCraft2RealmEnum,System.UInt64,System.String)')
  - [GetStaticProfile(accessToken,region,regionId,locale)](#M-Dysnomia-Common-BlizzardWebAPI-IStarcraftCommunity-GetStaticProfile-System-String,System-String,System-Int32,System-String- 'Dysnomia.Common.BlizzardWebAPI.IStarcraftCommunity.GetStaticProfile(System.String,System.String,System.Int32,System.String)')
  - [GetStaticProfile(accessToken,region,regionId,locale)](#M-Dysnomia-Common-BlizzardWebAPI-IStarcraftCommunity-GetStaticProfile-System-String,Dysnomia-Common-BlizzardWebAPI-Enums-RegionEnum,Dysnomia-Common-BlizzardWebAPI-Enums-StarCraft2RegionEnum,System-String- 'Dysnomia.Common.BlizzardWebAPI.IStarcraftCommunity.GetStaticProfile(System.String,Dysnomia.Common.BlizzardWebAPI.Enums.RegionEnum,Dysnomia.Common.BlizzardWebAPI.Enums.StarCraft2RegionEnum,System.String)')
- [LegacyStarcraftCommunity](#T-Dysnomia-Common-BlizzardWebAPI-LegacyStarcraftCommunity 'Dysnomia.Common.BlizzardWebAPI.LegacyStarcraftCommunity')
  - [GetPlayerProfile(accessToken,region,regionId,realmId,profileId)](#M-Dysnomia-Common-BlizzardWebAPI-LegacyStarcraftCommunity-GetPlayerProfile-System-String,System-String,System-Int32,System-Int32,System-UInt64- 'Dysnomia.Common.BlizzardWebAPI.LegacyStarcraftCommunity.GetPlayerProfile(System.String,System.String,System.Int32,System.Int32,System.UInt64)')
  - [GetPlayerProfile(accessToken,region,regionId,realmId,profileId)](#M-Dysnomia-Common-BlizzardWebAPI-LegacyStarcraftCommunity-GetPlayerProfile-System-String,Dysnomia-Common-BlizzardWebAPI-Enums-RegionEnum,Dysnomia-Common-BlizzardWebAPI-Enums-StarCraft2RegionEnum,Dysnomia-Common-BlizzardWebAPI-Enums-StarCraft2RealmEnum,System-UInt64- 'Dysnomia.Common.BlizzardWebAPI.LegacyStarcraftCommunity.GetPlayerProfile(System.String,Dysnomia.Common.BlizzardWebAPI.Enums.RegionEnum,Dysnomia.Common.BlizzardWebAPI.Enums.StarCraft2RegionEnum,Dysnomia.Common.BlizzardWebAPI.Enums.StarCraft2RealmEnum,System.UInt64)')
- [StarcraftCommunity](#T-Dysnomia-Common-BlizzardWebAPI-StarcraftCommunity 'Dysnomia.Common.BlizzardWebAPI.StarcraftCommunity')
  - [GetMetadataProfile(accessToken,region,regionId,realmId,profileId,locale)](#M-Dysnomia-Common-BlizzardWebAPI-StarcraftCommunity-GetMetadataProfile-System-String,System-String,System-Int32,System-Int32,System-UInt64,System-String- 'Dysnomia.Common.BlizzardWebAPI.StarcraftCommunity.GetMetadataProfile(System.String,System.String,System.Int32,System.Int32,System.UInt64,System.String)')
  - [GetMetadataProfile(accessToken,region,regionId,realmId,profileId,locale)](#M-Dysnomia-Common-BlizzardWebAPI-StarcraftCommunity-GetMetadataProfile-System-String,Dysnomia-Common-BlizzardWebAPI-Enums-RegionEnum,Dysnomia-Common-BlizzardWebAPI-Enums-StarCraft2RegionEnum,Dysnomia-Common-BlizzardWebAPI-Enums-StarCraft2RealmEnum,System-UInt64,System-String- 'Dysnomia.Common.BlizzardWebAPI.StarcraftCommunity.GetMetadataProfile(System.String,Dysnomia.Common.BlizzardWebAPI.Enums.RegionEnum,Dysnomia.Common.BlizzardWebAPI.Enums.StarCraft2RegionEnum,Dysnomia.Common.BlizzardWebAPI.Enums.StarCraft2RealmEnum,System.UInt64,System.String)')
  - [GetProfile(accessToken,region,regionId,realmId,profileId,locale)](#M-Dysnomia-Common-BlizzardWebAPI-StarcraftCommunity-GetProfile-System-String,System-String,System-Int32,System-Int32,System-UInt64,System-String- 'Dysnomia.Common.BlizzardWebAPI.StarcraftCommunity.GetProfile(System.String,System.String,System.Int32,System.Int32,System.UInt64,System.String)')
  - [GetProfile(accessToken,region,regionId,realmId,profileId,locale)](#M-Dysnomia-Common-BlizzardWebAPI-StarcraftCommunity-GetProfile-System-String,Dysnomia-Common-BlizzardWebAPI-Enums-RegionEnum,Dysnomia-Common-BlizzardWebAPI-Enums-StarCraft2RegionEnum,Dysnomia-Common-BlizzardWebAPI-Enums-StarCraft2RealmEnum,System-UInt64,System-String- 'Dysnomia.Common.BlizzardWebAPI.StarcraftCommunity.GetProfile(System.String,Dysnomia.Common.BlizzardWebAPI.Enums.RegionEnum,Dysnomia.Common.BlizzardWebAPI.Enums.StarCraft2RegionEnum,Dysnomia.Common.BlizzardWebAPI.Enums.StarCraft2RealmEnum,System.UInt64,System.String)')
  - [GetProfileLadder(accessToken,region,regionId,realmId,profileId,ladderId,locale)](#M-Dysnomia-Common-BlizzardWebAPI-StarcraftCommunity-GetProfileLadder-System-String,System-String,System-Int32,System-Int32,System-UInt64,System-Int32,System-String- 'Dysnomia.Common.BlizzardWebAPI.StarcraftCommunity.GetProfileLadder(System.String,System.String,System.Int32,System.Int32,System.UInt64,System.Int32,System.String)')
  - [GetProfileLadder(accessToken,region,regionId,realmId,profileId,ladderId,locale)](#M-Dysnomia-Common-BlizzardWebAPI-StarcraftCommunity-GetProfileLadder-System-String,Dysnomia-Common-BlizzardWebAPI-Enums-RegionEnum,Dysnomia-Common-BlizzardWebAPI-Enums-StarCraft2RegionEnum,Dysnomia-Common-BlizzardWebAPI-Enums-StarCraft2RealmEnum,System-UInt64,System-Int32,System-String- 'Dysnomia.Common.BlizzardWebAPI.StarcraftCommunity.GetProfileLadder(System.String,Dysnomia.Common.BlizzardWebAPI.Enums.RegionEnum,Dysnomia.Common.BlizzardWebAPI.Enums.StarCraft2RegionEnum,Dysnomia.Common.BlizzardWebAPI.Enums.StarCraft2RealmEnum,System.UInt64,System.Int32,System.String)')
  - [GetProfileLadderSummary(accessToken,region,regionId,realmId,profileId,locale)](#M-Dysnomia-Common-BlizzardWebAPI-StarcraftCommunity-GetProfileLadderSummary-System-String,System-String,System-Int32,System-Int32,System-UInt64,System-String- 'Dysnomia.Common.BlizzardWebAPI.StarcraftCommunity.GetProfileLadderSummary(System.String,System.String,System.Int32,System.Int32,System.UInt64,System.String)')
  - [GetProfileLadderSummary(accessToken,region,regionId,realmId,profileId,locale)](#M-Dysnomia-Common-BlizzardWebAPI-StarcraftCommunity-GetProfileLadderSummary-System-String,Dysnomia-Common-BlizzardWebAPI-Enums-RegionEnum,Dysnomia-Common-BlizzardWebAPI-Enums-StarCraft2RegionEnum,Dysnomia-Common-BlizzardWebAPI-Enums-StarCraft2RealmEnum,System-UInt64,System-String- 'Dysnomia.Common.BlizzardWebAPI.StarcraftCommunity.GetProfileLadderSummary(System.String,Dysnomia.Common.BlizzardWebAPI.Enums.RegionEnum,Dysnomia.Common.BlizzardWebAPI.Enums.StarCraft2RegionEnum,Dysnomia.Common.BlizzardWebAPI.Enums.StarCraft2RealmEnum,System.UInt64,System.String)')
  - [GetStaticProfile(accessToken,region,regionId,locale)](#M-Dysnomia-Common-BlizzardWebAPI-StarcraftCommunity-GetStaticProfile-System-String,System-String,System-Int32,System-String- 'Dysnomia.Common.BlizzardWebAPI.StarcraftCommunity.GetStaticProfile(System.String,System.String,System.Int32,System.String)')
  - [GetStaticProfile(accessToken,region,regionId,locale)](#M-Dysnomia-Common-BlizzardWebAPI-StarcraftCommunity-GetStaticProfile-System-String,Dysnomia-Common-BlizzardWebAPI-Enums-RegionEnum,Dysnomia-Common-BlizzardWebAPI-Enums-StarCraft2RegionEnum,System-String- 'Dysnomia.Common.BlizzardWebAPI.StarcraftCommunity.GetStaticProfile(System.String,Dysnomia.Common.BlizzardWebAPI.Enums.RegionEnum,Dysnomia.Common.BlizzardWebAPI.Enums.StarCraft2RegionEnum,System.String)')
- [TokenQuerier](#T-Dysnomia-Common-BlizzardWebAPI-TokenQuerier 'Dysnomia.Common.BlizzardWebAPI.TokenQuerier')
  - [GetAuthorizationCodeFlow(authorization_code,scope)](#M-Dysnomia-Common-BlizzardWebAPI-TokenQuerier-GetAuthorizationCodeFlow-System-String,System-String- 'Dysnomia.Common.BlizzardWebAPI.TokenQuerier.GetAuthorizationCodeFlow(System.String,System.String)')
  - [GetClientCredentialFlow()](#M-Dysnomia-Common-BlizzardWebAPI-TokenQuerier-GetClientCredentialFlow 'Dysnomia.Common.BlizzardWebAPI.TokenQuerier.GetClientCredentialFlow')

<a name='T-Dysnomia-Common-BlizzardWebAPI-ILegacyStarcraftCommunity'></a>
## ILegacyStarcraftCommunity `type`

##### Namespace

Dysnomia.Common.BlizzardWebAPI

##### Summary

See https://develop.battle.net/documentation/starcraft-2/community-apis, under "Legacy API"

<a name='M-Dysnomia-Common-BlizzardWebAPI-ILegacyStarcraftCommunity-GetPlayerProfile-System-String,System-String,System-Int32,System-Int32,System-UInt64-'></a>
### GetPlayerProfile(accessToken,region,regionId,realmId,profileId) `method`

##### Summary

Retrieves data about an individual SC2 profile.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| accessToken | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Credential Code Flow access token |
| region | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | StarCraft II community APIs use the region parameter to set the host region in the Try It feature. Note: {region} does not affect StarCraft II responses, which use the :regionId parameter in requests. |
| regionId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | You can retrieve these parameters by issuing a GetPlayerAccount request. |
| realmId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | You can retrieve these parameters by issuing a GetPlayerAccount request. |
| profileId | [System.UInt64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt64 'System.UInt64') | You can retrieve these parameters by issuing a GetPlayerAccount request. |

<a name='M-Dysnomia-Common-BlizzardWebAPI-ILegacyStarcraftCommunity-GetPlayerProfile-System-String,Dysnomia-Common-BlizzardWebAPI-Enums-RegionEnum,Dysnomia-Common-BlizzardWebAPI-Enums-StarCraft2RegionEnum,Dysnomia-Common-BlizzardWebAPI-Enums-StarCraft2RealmEnum,System-UInt64-'></a>
### GetPlayerProfile(accessToken,region,regionId,realmId,profileId) `method`

##### Summary

Retrieves data about an individual SC2 profile.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| accessToken | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Credential Code Flow access token |
| region | [Dysnomia.Common.BlizzardWebAPI.Enums.RegionEnum](#T-Dysnomia-Common-BlizzardWebAPI-Enums-RegionEnum 'Dysnomia.Common.BlizzardWebAPI.Enums.RegionEnum') | StarCraft II community APIs use the region parameter to set the host region in the Try It feature. Note: {region} does not affect StarCraft II responses, which use the :regionId parameter in requests. |
| regionId | [Dysnomia.Common.BlizzardWebAPI.Enums.StarCraft2RegionEnum](#T-Dysnomia-Common-BlizzardWebAPI-Enums-StarCraft2RegionEnum 'Dysnomia.Common.BlizzardWebAPI.Enums.StarCraft2RegionEnum') | You can retrieve these parameters by issuing a GetPlayerAccount request. |
| realmId | [Dysnomia.Common.BlizzardWebAPI.Enums.StarCraft2RealmEnum](#T-Dysnomia-Common-BlizzardWebAPI-Enums-StarCraft2RealmEnum 'Dysnomia.Common.BlizzardWebAPI.Enums.StarCraft2RealmEnum') | You can retrieve these parameters by issuing a GetPlayerAccount request. |
| profileId | [System.UInt64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt64 'System.UInt64') | You can retrieve these parameters by issuing a GetPlayerAccount request. |

<a name='T-Dysnomia-Common-BlizzardWebAPI-IStarcraftCommunity'></a>
## IStarcraftCommunity `type`

##### Namespace

Dysnomia.Common.BlizzardWebAPI

##### Summary

See https://develop.battle.net/documentation/starcraft-2/community-apis

<a name='M-Dysnomia-Common-BlizzardWebAPI-IStarcraftCommunity-GetMetadataProfile-System-String,System-String,System-Int32,System-Int32,System-UInt64,System-String-'></a>
### GetMetadataProfile(accessToken,region,regionId,realmId,profileId,locale) `method`

##### Summary

Returns metadata for an individual's profile.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| accessToken | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Credential Code Flow access token |
| region | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The region of the data to retrieve. |
| regionId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The region for the profile |
| realmId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Realm Id (1/2) |
| profileId | [System.UInt64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt64 'System.UInt64') | The profile ID |
| locale | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The locale to reflect in localized data. |

<a name='M-Dysnomia-Common-BlizzardWebAPI-IStarcraftCommunity-GetMetadataProfile-System-String,Dysnomia-Common-BlizzardWebAPI-Enums-RegionEnum,Dysnomia-Common-BlizzardWebAPI-Enums-StarCraft2RegionEnum,Dysnomia-Common-BlizzardWebAPI-Enums-StarCraft2RealmEnum,System-UInt64,System-String-'></a>
### GetMetadataProfile(accessToken,region,regionId,realmId,profileId,locale) `method`

##### Summary

Returns metadata for an individual's profile.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| accessToken | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Credential Code Flow access token |
| region | [Dysnomia.Common.BlizzardWebAPI.Enums.RegionEnum](#T-Dysnomia-Common-BlizzardWebAPI-Enums-RegionEnum 'Dysnomia.Common.BlizzardWebAPI.Enums.RegionEnum') | The region of the data to retrieve. |
| regionId | [Dysnomia.Common.BlizzardWebAPI.Enums.StarCraft2RegionEnum](#T-Dysnomia-Common-BlizzardWebAPI-Enums-StarCraft2RegionEnum 'Dysnomia.Common.BlizzardWebAPI.Enums.StarCraft2RegionEnum') | The region for the profile |
| realmId | [Dysnomia.Common.BlizzardWebAPI.Enums.StarCraft2RealmEnum](#T-Dysnomia-Common-BlizzardWebAPI-Enums-StarCraft2RealmEnum 'Dysnomia.Common.BlizzardWebAPI.Enums.StarCraft2RealmEnum') | Realm Id (1/2) |
| profileId | [System.UInt64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt64 'System.UInt64') | The profile ID |
| locale | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The locale to reflect in localized data. |

<a name='M-Dysnomia-Common-BlizzardWebAPI-IStarcraftCommunity-GetProfile-System-String,System-String,System-Int32,System-Int32,System-UInt64,System-String-'></a>
### GetProfile(accessToken,region,regionId,realmId,profileId,locale) `method`

##### Summary

Returns data about an individual SC2 profile.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| accessToken | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Credential Code Flow access token |
| region | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The region of the data to retrieve. |
| regionId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The region for the profile |
| realmId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Realm Id (1/2) |
| profileId | [System.UInt64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt64 'System.UInt64') | The profile ID |
| locale | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The locale to reflect in localized data. |

<a name='M-Dysnomia-Common-BlizzardWebAPI-IStarcraftCommunity-GetProfile-System-String,Dysnomia-Common-BlizzardWebAPI-Enums-RegionEnum,Dysnomia-Common-BlizzardWebAPI-Enums-StarCraft2RegionEnum,Dysnomia-Common-BlizzardWebAPI-Enums-StarCraft2RealmEnum,System-UInt64,System-String-'></a>
### GetProfile(accessToken,region,regionId,realmId,profileId,locale) `method`

##### Summary

Returns data about an individual SC2 profile.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| accessToken | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Credential Code Flow access token |
| region | [Dysnomia.Common.BlizzardWebAPI.Enums.RegionEnum](#T-Dysnomia-Common-BlizzardWebAPI-Enums-RegionEnum 'Dysnomia.Common.BlizzardWebAPI.Enums.RegionEnum') | The region of the data to retrieve. |
| regionId | [Dysnomia.Common.BlizzardWebAPI.Enums.StarCraft2RegionEnum](#T-Dysnomia-Common-BlizzardWebAPI-Enums-StarCraft2RegionEnum 'Dysnomia.Common.BlizzardWebAPI.Enums.StarCraft2RegionEnum') | The region for the profile |
| realmId | [Dysnomia.Common.BlizzardWebAPI.Enums.StarCraft2RealmEnum](#T-Dysnomia-Common-BlizzardWebAPI-Enums-StarCraft2RealmEnum 'Dysnomia.Common.BlizzardWebAPI.Enums.StarCraft2RealmEnum') | Realm Id (1/2) |
| profileId | [System.UInt64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt64 'System.UInt64') | The profile ID |
| locale | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The locale to reflect in localized data. |

<a name='M-Dysnomia-Common-BlizzardWebAPI-IStarcraftCommunity-GetProfileLadder-System-String,System-String,System-Int32,System-Int32,System-UInt64,System-Int32,System-String-'></a>
### GetProfileLadder(accessToken,region,regionId,realmId,profileId,ladderId,locale) `method`

##### Summary

Returns data about an individual profile's ladder.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| accessToken | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Credential Code Flow access token |
| region | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The region of the data to retrieve. |
| regionId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The region for the profile |
| realmId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Realm Id (1/2) |
| profileId | [System.UInt64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt64 'System.UInt64') | The profile ID |
| ladderId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The ID of the ladder for which to retrieve data. |
| locale | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The locale to reflect in localized data. |

<a name='M-Dysnomia-Common-BlizzardWebAPI-IStarcraftCommunity-GetProfileLadder-System-String,Dysnomia-Common-BlizzardWebAPI-Enums-RegionEnum,Dysnomia-Common-BlizzardWebAPI-Enums-StarCraft2RegionEnum,Dysnomia-Common-BlizzardWebAPI-Enums-StarCraft2RealmEnum,System-UInt64,System-Int32,System-String-'></a>
### GetProfileLadder(accessToken,region,regionId,realmId,profileId,ladderId,locale) `method`

##### Summary

Returns data about an individual profile's ladder.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| accessToken | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Credential Code Flow access token |
| region | [Dysnomia.Common.BlizzardWebAPI.Enums.RegionEnum](#T-Dysnomia-Common-BlizzardWebAPI-Enums-RegionEnum 'Dysnomia.Common.BlizzardWebAPI.Enums.RegionEnum') | The region of the data to retrieve. |
| regionId | [Dysnomia.Common.BlizzardWebAPI.Enums.StarCraft2RegionEnum](#T-Dysnomia-Common-BlizzardWebAPI-Enums-StarCraft2RegionEnum 'Dysnomia.Common.BlizzardWebAPI.Enums.StarCraft2RegionEnum') | The region for the profile |
| realmId | [Dysnomia.Common.BlizzardWebAPI.Enums.StarCraft2RealmEnum](#T-Dysnomia-Common-BlizzardWebAPI-Enums-StarCraft2RealmEnum 'Dysnomia.Common.BlizzardWebAPI.Enums.StarCraft2RealmEnum') | Realm Id (1/2) |
| profileId | [System.UInt64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt64 'System.UInt64') | The profile ID |
| ladderId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The ID of the ladder for which to retrieve data. |
| locale | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The locale to reflect in localized data. |

<a name='M-Dysnomia-Common-BlizzardWebAPI-IStarcraftCommunity-GetProfileLadderSummary-System-String,System-String,System-Int32,System-Int32,System-UInt64,System-String-'></a>
### GetProfileLadderSummary(accessToken,region,regionId,realmId,profileId,locale) `method`

##### Summary

Returns a ladder summary for an individual SC2 profile.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| accessToken | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Credential Code Flow access token |
| region | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The region of the data to retrieve. |
| regionId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The region for the profile |
| realmId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Realm Id (1/2) |
| profileId | [System.UInt64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt64 'System.UInt64') | The profile ID |
| locale | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The locale to reflect in localized data. |

<a name='M-Dysnomia-Common-BlizzardWebAPI-IStarcraftCommunity-GetProfileLadderSummary-System-String,Dysnomia-Common-BlizzardWebAPI-Enums-RegionEnum,Dysnomia-Common-BlizzardWebAPI-Enums-StarCraft2RegionEnum,Dysnomia-Common-BlizzardWebAPI-Enums-StarCraft2RealmEnum,System-UInt64,System-String-'></a>
### GetProfileLadderSummary(accessToken,region,regionId,realmId,profileId,locale) `method`

##### Summary

Returns a ladder summary for an individual SC2 profile.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| accessToken | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Credential Code Flow access token |
| region | [Dysnomia.Common.BlizzardWebAPI.Enums.RegionEnum](#T-Dysnomia-Common-BlizzardWebAPI-Enums-RegionEnum 'Dysnomia.Common.BlizzardWebAPI.Enums.RegionEnum') | The region of the data to retrieve. |
| regionId | [Dysnomia.Common.BlizzardWebAPI.Enums.StarCraft2RegionEnum](#T-Dysnomia-Common-BlizzardWebAPI-Enums-StarCraft2RegionEnum 'Dysnomia.Common.BlizzardWebAPI.Enums.StarCraft2RegionEnum') | The region for the profile |
| realmId | [Dysnomia.Common.BlizzardWebAPI.Enums.StarCraft2RealmEnum](#T-Dysnomia-Common-BlizzardWebAPI-Enums-StarCraft2RealmEnum 'Dysnomia.Common.BlizzardWebAPI.Enums.StarCraft2RealmEnum') | Realm Id (1/2) |
| profileId | [System.UInt64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt64 'System.UInt64') | The profile ID |
| locale | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The locale to reflect in localized data. |

<a name='M-Dysnomia-Common-BlizzardWebAPI-IStarcraftCommunity-GetStaticProfile-System-String,System-String,System-Int32,System-String-'></a>
### GetStaticProfile(accessToken,region,regionId,locale) `method`

##### Summary

Returns all static SC2 profile data (achievements, categories, criteria, and rewards).

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| accessToken | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Credential Code Flow access token |
| region | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The region of the data to retrieve. |
| regionId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The region for the profile |
| locale | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The locale to reflect in localized data. |

<a name='M-Dysnomia-Common-BlizzardWebAPI-IStarcraftCommunity-GetStaticProfile-System-String,Dysnomia-Common-BlizzardWebAPI-Enums-RegionEnum,Dysnomia-Common-BlizzardWebAPI-Enums-StarCraft2RegionEnum,System-String-'></a>
### GetStaticProfile(accessToken,region,regionId,locale) `method`

##### Summary

Returns all static SC2 profile data (achievements, categories, criteria, and rewards).

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| accessToken | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Credential Code Flow access token |
| region | [Dysnomia.Common.BlizzardWebAPI.Enums.RegionEnum](#T-Dysnomia-Common-BlizzardWebAPI-Enums-RegionEnum 'Dysnomia.Common.BlizzardWebAPI.Enums.RegionEnum') | The region of the data to retrieve. |
| regionId | [Dysnomia.Common.BlizzardWebAPI.Enums.StarCraft2RegionEnum](#T-Dysnomia-Common-BlizzardWebAPI-Enums-StarCraft2RegionEnum 'Dysnomia.Common.BlizzardWebAPI.Enums.StarCraft2RegionEnum') | The region for the profile |
| locale | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The locale to reflect in localized data. |

<a name='T-Dysnomia-Common-BlizzardWebAPI-LegacyStarcraftCommunity'></a>
## LegacyStarcraftCommunity `type`

##### Namespace

Dysnomia.Common.BlizzardWebAPI

##### Summary

See https://develop.battle.net/documentation/starcraft-2/community-apis, under "Legacy API"

<a name='M-Dysnomia-Common-BlizzardWebAPI-LegacyStarcraftCommunity-GetPlayerProfile-System-String,System-String,System-Int32,System-Int32,System-UInt64-'></a>
### GetPlayerProfile(accessToken,region,regionId,realmId,profileId) `method`

##### Summary

Retrieves data about an individual SC2 profile.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| accessToken | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Credential Code Flow access token |
| region | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | StarCraft II community APIs use the region parameter to set the host region in the Try It feature. Note: {region} does not affect StarCraft II responses, which use the :regionId parameter in requests. |
| regionId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | You can retrieve these parameters by issuing a GetPlayerAccount request. |
| realmId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | You can retrieve these parameters by issuing a GetPlayerAccount request. |
| profileId | [System.UInt64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt64 'System.UInt64') | You can retrieve these parameters by issuing a GetPlayerAccount request. |

<a name='M-Dysnomia-Common-BlizzardWebAPI-LegacyStarcraftCommunity-GetPlayerProfile-System-String,Dysnomia-Common-BlizzardWebAPI-Enums-RegionEnum,Dysnomia-Common-BlizzardWebAPI-Enums-StarCraft2RegionEnum,Dysnomia-Common-BlizzardWebAPI-Enums-StarCraft2RealmEnum,System-UInt64-'></a>
### GetPlayerProfile(accessToken,region,regionId,realmId,profileId) `method`

##### Summary

Retrieves data about an individual SC2 profile.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| accessToken | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Credential Code Flow access token |
| region | [Dysnomia.Common.BlizzardWebAPI.Enums.RegionEnum](#T-Dysnomia-Common-BlizzardWebAPI-Enums-RegionEnum 'Dysnomia.Common.BlizzardWebAPI.Enums.RegionEnum') | StarCraft II community APIs use the region parameter to set the host region in the Try It feature. Note: {region} does not affect StarCraft II responses, which use the :regionId parameter in requests. |
| regionId | [Dysnomia.Common.BlizzardWebAPI.Enums.StarCraft2RegionEnum](#T-Dysnomia-Common-BlizzardWebAPI-Enums-StarCraft2RegionEnum 'Dysnomia.Common.BlizzardWebAPI.Enums.StarCraft2RegionEnum') | You can retrieve these parameters by issuing a GetPlayerAccount request. |
| realmId | [Dysnomia.Common.BlizzardWebAPI.Enums.StarCraft2RealmEnum](#T-Dysnomia-Common-BlizzardWebAPI-Enums-StarCraft2RealmEnum 'Dysnomia.Common.BlizzardWebAPI.Enums.StarCraft2RealmEnum') | You can retrieve these parameters by issuing a GetPlayerAccount request. |
| profileId | [System.UInt64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt64 'System.UInt64') | You can retrieve these parameters by issuing a GetPlayerAccount request. |

<a name='T-Dysnomia-Common-BlizzardWebAPI-StarcraftCommunity'></a>
## StarcraftCommunity `type`

##### Namespace

Dysnomia.Common.BlizzardWebAPI

##### Summary

See https://develop.battle.net/documentation/starcraft-2/community-apis

<a name='M-Dysnomia-Common-BlizzardWebAPI-StarcraftCommunity-GetMetadataProfile-System-String,System-String,System-Int32,System-Int32,System-UInt64,System-String-'></a>
### GetMetadataProfile(accessToken,region,regionId,realmId,profileId,locale) `method`

##### Summary

Returns metadata for an individual's profile.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| accessToken | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Credential Code Flow access token |
| region | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The region of the data to retrieve. |
| regionId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The region for the profile |
| realmId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Realm Id (1/2) |
| profileId | [System.UInt64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt64 'System.UInt64') | The profile ID |
| locale | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The locale to reflect in localized data. |

<a name='M-Dysnomia-Common-BlizzardWebAPI-StarcraftCommunity-GetMetadataProfile-System-String,Dysnomia-Common-BlizzardWebAPI-Enums-RegionEnum,Dysnomia-Common-BlizzardWebAPI-Enums-StarCraft2RegionEnum,Dysnomia-Common-BlizzardWebAPI-Enums-StarCraft2RealmEnum,System-UInt64,System-String-'></a>
### GetMetadataProfile(accessToken,region,regionId,realmId,profileId,locale) `method`

##### Summary

Returns metadata for an individual's profile.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| accessToken | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Credential Code Flow access token |
| region | [Dysnomia.Common.BlizzardWebAPI.Enums.RegionEnum](#T-Dysnomia-Common-BlizzardWebAPI-Enums-RegionEnum 'Dysnomia.Common.BlizzardWebAPI.Enums.RegionEnum') | The region of the data to retrieve. |
| regionId | [Dysnomia.Common.BlizzardWebAPI.Enums.StarCraft2RegionEnum](#T-Dysnomia-Common-BlizzardWebAPI-Enums-StarCraft2RegionEnum 'Dysnomia.Common.BlizzardWebAPI.Enums.StarCraft2RegionEnum') | The region for the profile |
| realmId | [Dysnomia.Common.BlizzardWebAPI.Enums.StarCraft2RealmEnum](#T-Dysnomia-Common-BlizzardWebAPI-Enums-StarCraft2RealmEnum 'Dysnomia.Common.BlizzardWebAPI.Enums.StarCraft2RealmEnum') | Realm Id (1/2) |
| profileId | [System.UInt64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt64 'System.UInt64') | The profile ID |
| locale | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The locale to reflect in localized data. |

<a name='M-Dysnomia-Common-BlizzardWebAPI-StarcraftCommunity-GetProfile-System-String,System-String,System-Int32,System-Int32,System-UInt64,System-String-'></a>
### GetProfile(accessToken,region,regionId,realmId,profileId,locale) `method`

##### Summary

Returns data about an individual SC2 profile.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| accessToken | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Credential Code Flow access token |
| region | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The region of the data to retrieve. |
| regionId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The region for the profile |
| realmId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Realm Id (1/2) |
| profileId | [System.UInt64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt64 'System.UInt64') | The profile ID |
| locale | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The locale to reflect in localized data. |

<a name='M-Dysnomia-Common-BlizzardWebAPI-StarcraftCommunity-GetProfile-System-String,Dysnomia-Common-BlizzardWebAPI-Enums-RegionEnum,Dysnomia-Common-BlizzardWebAPI-Enums-StarCraft2RegionEnum,Dysnomia-Common-BlizzardWebAPI-Enums-StarCraft2RealmEnum,System-UInt64,System-String-'></a>
### GetProfile(accessToken,region,regionId,realmId,profileId,locale) `method`

##### Summary

Returns data about an individual SC2 profile.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| accessToken | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Credential Code Flow access token |
| region | [Dysnomia.Common.BlizzardWebAPI.Enums.RegionEnum](#T-Dysnomia-Common-BlizzardWebAPI-Enums-RegionEnum 'Dysnomia.Common.BlizzardWebAPI.Enums.RegionEnum') | The region of the data to retrieve. |
| regionId | [Dysnomia.Common.BlizzardWebAPI.Enums.StarCraft2RegionEnum](#T-Dysnomia-Common-BlizzardWebAPI-Enums-StarCraft2RegionEnum 'Dysnomia.Common.BlizzardWebAPI.Enums.StarCraft2RegionEnum') | The region for the profile |
| realmId | [Dysnomia.Common.BlizzardWebAPI.Enums.StarCraft2RealmEnum](#T-Dysnomia-Common-BlizzardWebAPI-Enums-StarCraft2RealmEnum 'Dysnomia.Common.BlizzardWebAPI.Enums.StarCraft2RealmEnum') | Realm Id (1/2) |
| profileId | [System.UInt64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt64 'System.UInt64') | The profile ID |
| locale | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The locale to reflect in localized data. |

<a name='M-Dysnomia-Common-BlizzardWebAPI-StarcraftCommunity-GetProfileLadder-System-String,System-String,System-Int32,System-Int32,System-UInt64,System-Int32,System-String-'></a>
### GetProfileLadder(accessToken,region,regionId,realmId,profileId,ladderId,locale) `method`

##### Summary

Returns data about an individual profile's ladder.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| accessToken | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Credential Code Flow access token |
| region | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The region of the data to retrieve. |
| regionId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The region for the profile |
| realmId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Realm Id (1/2) |
| profileId | [System.UInt64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt64 'System.UInt64') | The profile ID |
| ladderId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The ID of the ladder for which to retrieve data. |
| locale | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The locale to reflect in localized data. |

<a name='M-Dysnomia-Common-BlizzardWebAPI-StarcraftCommunity-GetProfileLadder-System-String,Dysnomia-Common-BlizzardWebAPI-Enums-RegionEnum,Dysnomia-Common-BlizzardWebAPI-Enums-StarCraft2RegionEnum,Dysnomia-Common-BlizzardWebAPI-Enums-StarCraft2RealmEnum,System-UInt64,System-Int32,System-String-'></a>
### GetProfileLadder(accessToken,region,regionId,realmId,profileId,ladderId,locale) `method`

##### Summary

Returns data about an individual profile's ladder.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| accessToken | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Credential Code Flow access token |
| region | [Dysnomia.Common.BlizzardWebAPI.Enums.RegionEnum](#T-Dysnomia-Common-BlizzardWebAPI-Enums-RegionEnum 'Dysnomia.Common.BlizzardWebAPI.Enums.RegionEnum') | The region of the data to retrieve. |
| regionId | [Dysnomia.Common.BlizzardWebAPI.Enums.StarCraft2RegionEnum](#T-Dysnomia-Common-BlizzardWebAPI-Enums-StarCraft2RegionEnum 'Dysnomia.Common.BlizzardWebAPI.Enums.StarCraft2RegionEnum') | The region for the profile |
| realmId | [Dysnomia.Common.BlizzardWebAPI.Enums.StarCraft2RealmEnum](#T-Dysnomia-Common-BlizzardWebAPI-Enums-StarCraft2RealmEnum 'Dysnomia.Common.BlizzardWebAPI.Enums.StarCraft2RealmEnum') | Realm Id (1/2) |
| profileId | [System.UInt64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt64 'System.UInt64') | The profile ID |
| ladderId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The ID of the ladder for which to retrieve data. |
| locale | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The locale to reflect in localized data. |

<a name='M-Dysnomia-Common-BlizzardWebAPI-StarcraftCommunity-GetProfileLadderSummary-System-String,System-String,System-Int32,System-Int32,System-UInt64,System-String-'></a>
### GetProfileLadderSummary(accessToken,region,regionId,realmId,profileId,locale) `method`

##### Summary

Returns a ladder summary for an individual SC2 profile.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| accessToken | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Credential Code Flow access token |
| region | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The region of the data to retrieve. |
| regionId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The region for the profile |
| realmId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Realm Id (1/2) |
| profileId | [System.UInt64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt64 'System.UInt64') | The profile ID |
| locale | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The locale to reflect in localized data. |

<a name='M-Dysnomia-Common-BlizzardWebAPI-StarcraftCommunity-GetProfileLadderSummary-System-String,Dysnomia-Common-BlizzardWebAPI-Enums-RegionEnum,Dysnomia-Common-BlizzardWebAPI-Enums-StarCraft2RegionEnum,Dysnomia-Common-BlizzardWebAPI-Enums-StarCraft2RealmEnum,System-UInt64,System-String-'></a>
### GetProfileLadderSummary(accessToken,region,regionId,realmId,profileId,locale) `method`

##### Summary

Returns a ladder summary for an individual SC2 profile.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| accessToken | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Credential Code Flow access token |
| region | [Dysnomia.Common.BlizzardWebAPI.Enums.RegionEnum](#T-Dysnomia-Common-BlizzardWebAPI-Enums-RegionEnum 'Dysnomia.Common.BlizzardWebAPI.Enums.RegionEnum') | The region of the data to retrieve. |
| regionId | [Dysnomia.Common.BlizzardWebAPI.Enums.StarCraft2RegionEnum](#T-Dysnomia-Common-BlizzardWebAPI-Enums-StarCraft2RegionEnum 'Dysnomia.Common.BlizzardWebAPI.Enums.StarCraft2RegionEnum') | The region for the profile |
| realmId | [Dysnomia.Common.BlizzardWebAPI.Enums.StarCraft2RealmEnum](#T-Dysnomia-Common-BlizzardWebAPI-Enums-StarCraft2RealmEnum 'Dysnomia.Common.BlizzardWebAPI.Enums.StarCraft2RealmEnum') | Realm Id (1/2) |
| profileId | [System.UInt64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt64 'System.UInt64') | The profile ID |
| locale | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The locale to reflect in localized data. |

<a name='M-Dysnomia-Common-BlizzardWebAPI-StarcraftCommunity-GetStaticProfile-System-String,System-String,System-Int32,System-String-'></a>
### GetStaticProfile(accessToken,region,regionId,locale) `method`

##### Summary

Returns all static SC2 profile data (achievements, categories, criteria, and rewards).

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| accessToken | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Credential Code Flow access token |
| region | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The region of the data to retrieve. |
| regionId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The region for the profile |
| locale | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The locale to reflect in localized data. |

<a name='M-Dysnomia-Common-BlizzardWebAPI-StarcraftCommunity-GetStaticProfile-System-String,Dysnomia-Common-BlizzardWebAPI-Enums-RegionEnum,Dysnomia-Common-BlizzardWebAPI-Enums-StarCraft2RegionEnum,System-String-'></a>
### GetStaticProfile(accessToken,region,regionId,locale) `method`

##### Summary

Returns all static SC2 profile data (achievements, categories, criteria, and rewards).

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| accessToken | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Credential Code Flow access token |
| region | [Dysnomia.Common.BlizzardWebAPI.Enums.RegionEnum](#T-Dysnomia-Common-BlizzardWebAPI-Enums-RegionEnum 'Dysnomia.Common.BlizzardWebAPI.Enums.RegionEnum') | The region of the data to retrieve. |
| regionId | [Dysnomia.Common.BlizzardWebAPI.Enums.StarCraft2RegionEnum](#T-Dysnomia-Common-BlizzardWebAPI-Enums-StarCraft2RegionEnum 'Dysnomia.Common.BlizzardWebAPI.Enums.StarCraft2RegionEnum') | The region for the profile |
| locale | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The locale to reflect in localized data. |

<a name='T-Dysnomia-Common-BlizzardWebAPI-TokenQuerier'></a>
## TokenQuerier `type`

##### Namespace

Dysnomia.Common.BlizzardWebAPI

##### Summary

See https://develop.battle.net/documentation/guides/using-oauth

<a name='M-Dysnomia-Common-BlizzardWebAPI-TokenQuerier-GetAuthorizationCodeFlow-System-String,System-String-'></a>
### GetAuthorizationCodeFlow(authorization_code,scope) `method`

##### Summary

The OAuth 2.0 Authorization Code Flow allows an application to access a user's data on their behalf. This allows an application to acquire more sensitive, opt-in information about a user, such as their list of World of Warcraft characters, after obtaining the user's permission to do so. The Authorization Code Flow has two major parts: the authorization code request and the access token request.
https://develop.battle.net/documentation/guides/using-oauth/authorization-code-flow

##### Returns

Access token response

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| authorization_code | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The previously-retrieved authorization_code. |
| scope | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The scopes needed for the access token. Note that this can be fewer scopes than the authorization. |

<a name='M-Dysnomia-Common-BlizzardWebAPI-TokenQuerier-GetClientCredentialFlow'></a>
### GetClientCredentialFlow() `method`

##### Summary

The OAuth client credentials flow is used to exchange a pair of client credentials (client_id and client_secret) for an access token.
https://develop.battle.net/documentation/guides/using-oauth/client-credentials-flow

##### Returns

Access token response

##### Parameters

This method has no parameters.
