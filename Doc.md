<a name='assembly'></a>
# Dysnomia.Common.BlizzardWebAPI

## Contents

- [ILegacyStarcraftCommunity](#T-Dysnomia-Common-BlizzardWebAPI-ILegacyStarcraftCommunity 'Dysnomia.Common.BlizzardWebAPI.ILegacyStarcraftCommunity')
  - [GetPlayerProfile(accessToken,region,regionId,realmId,profileId)](#M-Dysnomia-Common-BlizzardWebAPI-ILegacyStarcraftCommunity-GetPlayerProfile-System-String,System-String,System-Int32,System-Int32,System-UInt64- 'Dysnomia.Common.BlizzardWebAPI.ILegacyStarcraftCommunity.GetPlayerProfile(System.String,System.String,System.Int32,System.Int32,System.UInt64)')
- [LegacyStarcraftCommunity](#T-Dysnomia-Common-BlizzardWebAPI-LegacyStarcraftCommunity 'Dysnomia.Common.BlizzardWebAPI.LegacyStarcraftCommunity')
  - [GetPlayerProfile(accessToken,region,regionId,realmId,profileId)](#M-Dysnomia-Common-BlizzardWebAPI-LegacyStarcraftCommunity-GetPlayerProfile-System-String,System-String,System-Int32,System-Int32,System-UInt64- 'Dysnomia.Common.BlizzardWebAPI.LegacyStarcraftCommunity.GetPlayerProfile(System.String,System.String,System.Int32,System.Int32,System.UInt64)')
- [TokenQuerier](#T-Dysnomia-Common-BlizzardWebAPI-TokenQuerier 'Dysnomia.Common.BlizzardWebAPI.TokenQuerier')
  - [GetAuthorizationCodeFlow(authorization_code,scope)](#M-Dysnomia-Common-BlizzardWebAPI-TokenQuerier-GetAuthorizationCodeFlow-System-String,System-String- 'Dysnomia.Common.BlizzardWebAPI.TokenQuerier.GetAuthorizationCodeFlow(System.String,System.String)')
  - [GetClientCredentialFlow()](#M-Dysnomia-Common-BlizzardWebAPI-TokenQuerier-GetClientCredentialFlow 'Dysnomia.Common.BlizzardWebAPI.TokenQuerier.GetClientCredentialFlow')

<a name='T-Dysnomia-Common-BlizzardWebAPI-ILegacyStarcraftCommunity'></a>
## ILegacyStarcraftCommunity `type`

##### Namespace

Dysnomia.Common.BlizzardWebAPI

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

<a name='T-Dysnomia-Common-BlizzardWebAPI-LegacyStarcraftCommunity'></a>
## LegacyStarcraftCommunity `type`

##### Namespace

Dysnomia.Common.BlizzardWebAPI

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

<a name='T-Dysnomia-Common-BlizzardWebAPI-TokenQuerier'></a>
## TokenQuerier `type`

##### Namespace

Dysnomia.Common.BlizzardWebAPI

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