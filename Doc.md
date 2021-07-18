<a name='assembly'></a>
# Dysnomia.Common.BlizzardWebAPI

## Contents

- [Diablo3Community](#T-Dysnomia-Common-BlizzardWebAPI-Diablo3Community 'Dysnomia.Common.BlizzardWebAPI.Diablo3Community')
  - [GetAct(accessToken,region,actId,locale)](#M-Dysnomia-Common-BlizzardWebAPI-Diablo3Community-GetAct-System-String,System-String,System-Int32,System-String- 'Dysnomia.Common.BlizzardWebAPI.Diablo3Community.GetAct(System.String,System.String,System.Int32,System.String)')
  - [GetAct(accessToken,region,actId,locale)](#M-Dysnomia-Common-BlizzardWebAPI-Diablo3Community-GetAct-System-String,Dysnomia-Common-BlizzardWebAPI-Enums-RegionEnum,System-Int32,System-String- 'Dysnomia.Common.BlizzardWebAPI.Diablo3Community.GetAct(System.String,Dysnomia.Common.BlizzardWebAPI.Enums.RegionEnum,System.Int32,System.String)')
  - [GetActIndex(accessToken,region,locale)](#M-Dysnomia-Common-BlizzardWebAPI-Diablo3Community-GetActIndex-System-String,System-String,System-String- 'Dysnomia.Common.BlizzardWebAPI.Diablo3Community.GetActIndex(System.String,System.String,System.String)')
  - [GetActIndex(accessToken,region,locale)](#M-Dysnomia-Common-BlizzardWebAPI-Diablo3Community-GetActIndex-System-String,Dysnomia-Common-BlizzardWebAPI-Enums-RegionEnum,System-String- 'Dysnomia.Common.BlizzardWebAPI.Diablo3Community.GetActIndex(System.String,Dysnomia.Common.BlizzardWebAPI.Enums.RegionEnum,System.String)')
  - [GetArtisan(accessToken,region,artisanSlug,locale)](#M-Dysnomia-Common-BlizzardWebAPI-Diablo3Community-GetArtisan-System-String,System-String,System-String,System-String- 'Dysnomia.Common.BlizzardWebAPI.Diablo3Community.GetArtisan(System.String,System.String,System.String,System.String)')
  - [GetArtisan(accessToken,region,artisanSlug,locale)](#M-Dysnomia-Common-BlizzardWebAPI-Diablo3Community-GetArtisan-System-String,Dysnomia-Common-BlizzardWebAPI-Enums-RegionEnum,Dysnomia-Common-BlizzardWebAPI-Enums-Artisan,System-String- 'Dysnomia.Common.BlizzardWebAPI.Diablo3Community.GetArtisan(System.String,Dysnomia.Common.BlizzardWebAPI.Enums.RegionEnum,Dysnomia.Common.BlizzardWebAPI.Enums.Artisan,System.String)')
  - [GetFollower(accessToken,region,followerSlug,locale)](#M-Dysnomia-Common-BlizzardWebAPI-Diablo3Community-GetFollower-System-String,System-String,System-String,System-String- 'Dysnomia.Common.BlizzardWebAPI.Diablo3Community.GetFollower(System.String,System.String,System.String,System.String)')
  - [GetFollower(accessToken,region,followerSlug,locale)](#M-Dysnomia-Common-BlizzardWebAPI-Diablo3Community-GetFollower-System-String,Dysnomia-Common-BlizzardWebAPI-Enums-RegionEnum,Dysnomia-Common-BlizzardWebAPI-Enums-Follower,System-String- 'Dysnomia.Common.BlizzardWebAPI.Diablo3Community.GetFollower(System.String,Dysnomia.Common.BlizzardWebAPI.Enums.RegionEnum,Dysnomia.Common.BlizzardWebAPI.Enums.Follower,System.String)')
  - [GetImage(type,size,icon)](#M-Dysnomia-Common-BlizzardWebAPI-Diablo3Community-GetImage-Dysnomia-Common-BlizzardWebAPI-Enums-Diablo3ImageType,System-String,System-String- 'Dysnomia.Common.BlizzardWebAPI.Diablo3Community.GetImage(Dysnomia.Common.BlizzardWebAPI.Enums.Diablo3ImageType,System.String,System.String)')
  - [GetRecipe(accessToken,region,artisanSlug,recipeSlug,locale)](#M-Dysnomia-Common-BlizzardWebAPI-Diablo3Community-GetRecipe-System-String,System-String,System-String,System-String,System-String- 'Dysnomia.Common.BlizzardWebAPI.Diablo3Community.GetRecipe(System.String,System.String,System.String,System.String,System.String)')
  - [GetRecipe(accessToken,region,artisanSlug,recipeSlug,locale)](#M-Dysnomia-Common-BlizzardWebAPI-Diablo3Community-GetRecipe-System-String,Dysnomia-Common-BlizzardWebAPI-Enums-RegionEnum,Dysnomia-Common-BlizzardWebAPI-Enums-Artisan,System-String,System-String- 'Dysnomia.Common.BlizzardWebAPI.Diablo3Community.GetRecipe(System.String,Dysnomia.Common.BlizzardWebAPI.Enums.RegionEnum,Dysnomia.Common.BlizzardWebAPI.Enums.Artisan,System.String,System.String)')
- [IDiablo3Community](#T-Dysnomia-Common-BlizzardWebAPI-IDiablo3Community 'Dysnomia.Common.BlizzardWebAPI.IDiablo3Community')
  - [GetAct(accessToken,region,actId,locale)](#M-Dysnomia-Common-BlizzardWebAPI-IDiablo3Community-GetAct-System-String,System-String,System-Int32,System-String- 'Dysnomia.Common.BlizzardWebAPI.IDiablo3Community.GetAct(System.String,System.String,System.Int32,System.String)')
  - [GetAct(accessToken,region,actId,locale)](#M-Dysnomia-Common-BlizzardWebAPI-IDiablo3Community-GetAct-System-String,Dysnomia-Common-BlizzardWebAPI-Enums-RegionEnum,System-Int32,System-String- 'Dysnomia.Common.BlizzardWebAPI.IDiablo3Community.GetAct(System.String,Dysnomia.Common.BlizzardWebAPI.Enums.RegionEnum,System.Int32,System.String)')
  - [GetActIndex(accessToken,region,locale)](#M-Dysnomia-Common-BlizzardWebAPI-IDiablo3Community-GetActIndex-System-String,System-String,System-String- 'Dysnomia.Common.BlizzardWebAPI.IDiablo3Community.GetActIndex(System.String,System.String,System.String)')
  - [GetActIndex(accessToken,region,locale)](#M-Dysnomia-Common-BlizzardWebAPI-IDiablo3Community-GetActIndex-System-String,Dysnomia-Common-BlizzardWebAPI-Enums-RegionEnum,System-String- 'Dysnomia.Common.BlizzardWebAPI.IDiablo3Community.GetActIndex(System.String,Dysnomia.Common.BlizzardWebAPI.Enums.RegionEnum,System.String)')
  - [GetArtisan(accessToken,region,artisanSlug,locale)](#M-Dysnomia-Common-BlizzardWebAPI-IDiablo3Community-GetArtisan-System-String,System-String,System-String,System-String- 'Dysnomia.Common.BlizzardWebAPI.IDiablo3Community.GetArtisan(System.String,System.String,System.String,System.String)')
  - [GetArtisan(accessToken,region,artisanSlug,locale)](#M-Dysnomia-Common-BlizzardWebAPI-IDiablo3Community-GetArtisan-System-String,Dysnomia-Common-BlizzardWebAPI-Enums-RegionEnum,Dysnomia-Common-BlizzardWebAPI-Enums-Artisan,System-String- 'Dysnomia.Common.BlizzardWebAPI.IDiablo3Community.GetArtisan(System.String,Dysnomia.Common.BlizzardWebAPI.Enums.RegionEnum,Dysnomia.Common.BlizzardWebAPI.Enums.Artisan,System.String)')
  - [GetFollower(accessToken,region,followerSlug,locale)](#M-Dysnomia-Common-BlizzardWebAPI-IDiablo3Community-GetFollower-System-String,System-String,System-String,System-String- 'Dysnomia.Common.BlizzardWebAPI.IDiablo3Community.GetFollower(System.String,System.String,System.String,System.String)')
  - [GetFollower(accessToken,region,followerSlug,locale)](#M-Dysnomia-Common-BlizzardWebAPI-IDiablo3Community-GetFollower-System-String,Dysnomia-Common-BlizzardWebAPI-Enums-RegionEnum,Dysnomia-Common-BlizzardWebAPI-Enums-Follower,System-String- 'Dysnomia.Common.BlizzardWebAPI.IDiablo3Community.GetFollower(System.String,Dysnomia.Common.BlizzardWebAPI.Enums.RegionEnum,Dysnomia.Common.BlizzardWebAPI.Enums.Follower,System.String)')
  - [GetImage(type,size,icon)](#M-Dysnomia-Common-BlizzardWebAPI-IDiablo3Community-GetImage-Dysnomia-Common-BlizzardWebAPI-Enums-Diablo3ImageType,System-String,System-String- 'Dysnomia.Common.BlizzardWebAPI.IDiablo3Community.GetImage(Dysnomia.Common.BlizzardWebAPI.Enums.Diablo3ImageType,System.String,System.String)')
  - [GetRecipe(accessToken,region,artisanSlug,recipeSlug,locale)](#M-Dysnomia-Common-BlizzardWebAPI-IDiablo3Community-GetRecipe-System-String,System-String,System-String,System-String,System-String- 'Dysnomia.Common.BlizzardWebAPI.IDiablo3Community.GetRecipe(System.String,System.String,System.String,System.String,System.String)')
  - [GetRecipe(accessToken,region,artisanSlug,recipeSlug,locale)](#M-Dysnomia-Common-BlizzardWebAPI-IDiablo3Community-GetRecipe-System-String,Dysnomia-Common-BlizzardWebAPI-Enums-RegionEnum,Dysnomia-Common-BlizzardWebAPI-Enums-Artisan,System-String,System-String- 'Dysnomia.Common.BlizzardWebAPI.IDiablo3Community.GetRecipe(System.String,Dysnomia.Common.BlizzardWebAPI.Enums.RegionEnum,Dysnomia.Common.BlizzardWebAPI.Enums.Artisan,System.String,System.String)')
- [ILegacyStarcraft2Community](#T-Dysnomia-Common-BlizzardWebAPI-ILegacyStarcraft2Community 'Dysnomia.Common.BlizzardWebAPI.ILegacyStarcraft2Community')
  - [GetPlayerProfile(accessToken,region,regionId,realmId,profileId)](#M-Dysnomia-Common-BlizzardWebAPI-ILegacyStarcraft2Community-GetPlayerProfile-System-String,System-String,System-Int32,System-Int32,System-UInt64- 'Dysnomia.Common.BlizzardWebAPI.ILegacyStarcraft2Community.GetPlayerProfile(System.String,System.String,System.Int32,System.Int32,System.UInt64)')
  - [GetPlayerProfile(accessToken,region,regionId,realmId,profileId)](#M-Dysnomia-Common-BlizzardWebAPI-ILegacyStarcraft2Community-GetPlayerProfile-System-String,Dysnomia-Common-BlizzardWebAPI-Enums-RegionEnum,Dysnomia-Common-BlizzardWebAPI-Enums-StarCraft2RegionEnum,Dysnomia-Common-BlizzardWebAPI-Enums-StarCraft2RealmEnum,System-UInt64- 'Dysnomia.Common.BlizzardWebAPI.ILegacyStarcraft2Community.GetPlayerProfile(System.String,Dysnomia.Common.BlizzardWebAPI.Enums.RegionEnum,Dysnomia.Common.BlizzardWebAPI.Enums.StarCraft2RegionEnum,Dysnomia.Common.BlizzardWebAPI.Enums.StarCraft2RealmEnum,System.UInt64)')
- [IStarcraft2Community](#T-Dysnomia-Common-BlizzardWebAPI-IStarcraft2Community 'Dysnomia.Common.BlizzardWebAPI.IStarcraft2Community')
  - [GetGrandmasterLeaderboard(accessToken,region,regionId)](#M-Dysnomia-Common-BlizzardWebAPI-IStarcraft2Community-GetGrandmasterLeaderboard-System-String,System-String,System-Int32- 'Dysnomia.Common.BlizzardWebAPI.IStarcraft2Community.GetGrandmasterLeaderboard(System.String,System.String,System.Int32)')
  - [GetGrandmasterLeaderboard(accessToken,region,regionId)](#M-Dysnomia-Common-BlizzardWebAPI-IStarcraft2Community-GetGrandmasterLeaderboard-System-String,Dysnomia-Common-BlizzardWebAPI-Enums-RegionEnum,Dysnomia-Common-BlizzardWebAPI-Enums-StarCraft2RegionEnum- 'Dysnomia.Common.BlizzardWebAPI.IStarcraft2Community.GetGrandmasterLeaderboard(System.String,Dysnomia.Common.BlizzardWebAPI.Enums.RegionEnum,Dysnomia.Common.BlizzardWebAPI.Enums.StarCraft2RegionEnum)')
  - [GetLadderSeason(accessToken,region,regionId)](#M-Dysnomia-Common-BlizzardWebAPI-IStarcraft2Community-GetLadderSeason-System-String,System-String,System-Int32- 'Dysnomia.Common.BlizzardWebAPI.IStarcraft2Community.GetLadderSeason(System.String,System.String,System.Int32)')
  - [GetLadderSeason(accessToken,region,regionId)](#M-Dysnomia-Common-BlizzardWebAPI-IStarcraft2Community-GetLadderSeason-System-String,Dysnomia-Common-BlizzardWebAPI-Enums-RegionEnum,Dysnomia-Common-BlizzardWebAPI-Enums-StarCraft2RegionEnum- 'Dysnomia.Common.BlizzardWebAPI.IStarcraft2Community.GetLadderSeason(System.String,Dysnomia.Common.BlizzardWebAPI.Enums.RegionEnum,Dysnomia.Common.BlizzardWebAPI.Enums.StarCraft2RegionEnum)')
  - [GetMetadataProfile(accessToken,region,regionId,realmId,profileId,locale)](#M-Dysnomia-Common-BlizzardWebAPI-IStarcraft2Community-GetMetadataProfile-System-String,System-String,System-Int32,System-Int32,System-UInt64,System-String- 'Dysnomia.Common.BlizzardWebAPI.IStarcraft2Community.GetMetadataProfile(System.String,System.String,System.Int32,System.Int32,System.UInt64,System.String)')
  - [GetMetadataProfile(accessToken,region,regionId,realmId,profileId,locale)](#M-Dysnomia-Common-BlizzardWebAPI-IStarcraft2Community-GetMetadataProfile-System-String,Dysnomia-Common-BlizzardWebAPI-Enums-RegionEnum,Dysnomia-Common-BlizzardWebAPI-Enums-StarCraft2RegionEnum,Dysnomia-Common-BlizzardWebAPI-Enums-StarCraft2RealmEnum,System-UInt64,System-String- 'Dysnomia.Common.BlizzardWebAPI.IStarcraft2Community.GetMetadataProfile(System.String,Dysnomia.Common.BlizzardWebAPI.Enums.RegionEnum,Dysnomia.Common.BlizzardWebAPI.Enums.StarCraft2RegionEnum,Dysnomia.Common.BlizzardWebAPI.Enums.StarCraft2RealmEnum,System.UInt64,System.String)')
  - [GetPlayerAccount(accessToken,region,accountId)](#M-Dysnomia-Common-BlizzardWebAPI-IStarcraft2Community-GetPlayerAccount-System-String,System-String,System-UInt64- 'Dysnomia.Common.BlizzardWebAPI.IStarcraft2Community.GetPlayerAccount(System.String,System.String,System.UInt64)')
  - [GetPlayerAccount(accessToken,region,accountId)](#M-Dysnomia-Common-BlizzardWebAPI-IStarcraft2Community-GetPlayerAccount-System-String,Dysnomia-Common-BlizzardWebAPI-Enums-RegionEnum,System-UInt64- 'Dysnomia.Common.BlizzardWebAPI.IStarcraft2Community.GetPlayerAccount(System.String,Dysnomia.Common.BlizzardWebAPI.Enums.RegionEnum,System.UInt64)')
  - [GetProfile(accessToken,region,regionId,realmId,profileId,locale)](#M-Dysnomia-Common-BlizzardWebAPI-IStarcraft2Community-GetProfile-System-String,System-String,System-Int32,System-Int32,System-UInt64,System-String- 'Dysnomia.Common.BlizzardWebAPI.IStarcraft2Community.GetProfile(System.String,System.String,System.Int32,System.Int32,System.UInt64,System.String)')
  - [GetProfile(accessToken,region,regionId,realmId,profileId,locale)](#M-Dysnomia-Common-BlizzardWebAPI-IStarcraft2Community-GetProfile-System-String,Dysnomia-Common-BlizzardWebAPI-Enums-RegionEnum,Dysnomia-Common-BlizzardWebAPI-Enums-StarCraft2RegionEnum,Dysnomia-Common-BlizzardWebAPI-Enums-StarCraft2RealmEnum,System-UInt64,System-String- 'Dysnomia.Common.BlizzardWebAPI.IStarcraft2Community.GetProfile(System.String,Dysnomia.Common.BlizzardWebAPI.Enums.RegionEnum,Dysnomia.Common.BlizzardWebAPI.Enums.StarCraft2RegionEnum,Dysnomia.Common.BlizzardWebAPI.Enums.StarCraft2RealmEnum,System.UInt64,System.String)')
  - [GetProfileLadder(accessToken,region,regionId,realmId,profileId,ladderId,locale)](#M-Dysnomia-Common-BlizzardWebAPI-IStarcraft2Community-GetProfileLadder-System-String,System-String,System-Int32,System-Int32,System-UInt64,System-Int32,System-String- 'Dysnomia.Common.BlizzardWebAPI.IStarcraft2Community.GetProfileLadder(System.String,System.String,System.Int32,System.Int32,System.UInt64,System.Int32,System.String)')
  - [GetProfileLadder(accessToken,region,regionId,realmId,profileId,ladderId,locale)](#M-Dysnomia-Common-BlizzardWebAPI-IStarcraft2Community-GetProfileLadder-System-String,Dysnomia-Common-BlizzardWebAPI-Enums-RegionEnum,Dysnomia-Common-BlizzardWebAPI-Enums-StarCraft2RegionEnum,Dysnomia-Common-BlizzardWebAPI-Enums-StarCraft2RealmEnum,System-UInt64,System-Int32,System-String- 'Dysnomia.Common.BlizzardWebAPI.IStarcraft2Community.GetProfileLadder(System.String,Dysnomia.Common.BlizzardWebAPI.Enums.RegionEnum,Dysnomia.Common.BlizzardWebAPI.Enums.StarCraft2RegionEnum,Dysnomia.Common.BlizzardWebAPI.Enums.StarCraft2RealmEnum,System.UInt64,System.Int32,System.String)')
  - [GetProfileLadderSummary(accessToken,region,regionId,realmId,profileId,locale)](#M-Dysnomia-Common-BlizzardWebAPI-IStarcraft2Community-GetProfileLadderSummary-System-String,System-String,System-Int32,System-Int32,System-UInt64,System-String- 'Dysnomia.Common.BlizzardWebAPI.IStarcraft2Community.GetProfileLadderSummary(System.String,System.String,System.Int32,System.Int32,System.UInt64,System.String)')
  - [GetProfileLadderSummary(accessToken,region,regionId,realmId,profileId,locale)](#M-Dysnomia-Common-BlizzardWebAPI-IStarcraft2Community-GetProfileLadderSummary-System-String,Dysnomia-Common-BlizzardWebAPI-Enums-RegionEnum,Dysnomia-Common-BlizzardWebAPI-Enums-StarCraft2RegionEnum,Dysnomia-Common-BlizzardWebAPI-Enums-StarCraft2RealmEnum,System-UInt64,System-String- 'Dysnomia.Common.BlizzardWebAPI.IStarcraft2Community.GetProfileLadderSummary(System.String,Dysnomia.Common.BlizzardWebAPI.Enums.RegionEnum,Dysnomia.Common.BlizzardWebAPI.Enums.StarCraft2RegionEnum,Dysnomia.Common.BlizzardWebAPI.Enums.StarCraft2RealmEnum,System.UInt64,System.String)')
  - [GetStaticProfile(accessToken,region,regionId,locale)](#M-Dysnomia-Common-BlizzardWebAPI-IStarcraft2Community-GetStaticProfile-System-String,System-String,System-Int32,System-String- 'Dysnomia.Common.BlizzardWebAPI.IStarcraft2Community.GetStaticProfile(System.String,System.String,System.Int32,System.String)')
  - [GetStaticProfile(accessToken,region,regionId,locale)](#M-Dysnomia-Common-BlizzardWebAPI-IStarcraft2Community-GetStaticProfile-System-String,Dysnomia-Common-BlizzardWebAPI-Enums-RegionEnum,Dysnomia-Common-BlizzardWebAPI-Enums-StarCraft2RegionEnum,System-String- 'Dysnomia.Common.BlizzardWebAPI.IStarcraft2Community.GetStaticProfile(System.String,Dysnomia.Common.BlizzardWebAPI.Enums.RegionEnum,Dysnomia.Common.BlizzardWebAPI.Enums.StarCraft2RegionEnum,System.String)')
- [LegacyStarcraft2Community](#T-Dysnomia-Common-BlizzardWebAPI-LegacyStarcraft2Community 'Dysnomia.Common.BlizzardWebAPI.LegacyStarcraft2Community')
  - [GetPlayerProfile(accessToken,region,regionId,realmId,profileId)](#M-Dysnomia-Common-BlizzardWebAPI-LegacyStarcraft2Community-GetPlayerProfile-System-String,System-String,System-Int32,System-Int32,System-UInt64- 'Dysnomia.Common.BlizzardWebAPI.LegacyStarcraft2Community.GetPlayerProfile(System.String,System.String,System.Int32,System.Int32,System.UInt64)')
  - [GetPlayerProfile(accessToken,region,regionId,realmId,profileId)](#M-Dysnomia-Common-BlizzardWebAPI-LegacyStarcraft2Community-GetPlayerProfile-System-String,Dysnomia-Common-BlizzardWebAPI-Enums-RegionEnum,Dysnomia-Common-BlizzardWebAPI-Enums-StarCraft2RegionEnum,Dysnomia-Common-BlizzardWebAPI-Enums-StarCraft2RealmEnum,System-UInt64- 'Dysnomia.Common.BlizzardWebAPI.LegacyStarcraft2Community.GetPlayerProfile(System.String,Dysnomia.Common.BlizzardWebAPI.Enums.RegionEnum,Dysnomia.Common.BlizzardWebAPI.Enums.StarCraft2RegionEnum,Dysnomia.Common.BlizzardWebAPI.Enums.StarCraft2RealmEnum,System.UInt64)')
- [Starcraft2Community](#T-Dysnomia-Common-BlizzardWebAPI-Starcraft2Community 'Dysnomia.Common.BlizzardWebAPI.Starcraft2Community')
  - [GetGrandmasterLeaderboard(accessToken,region,regionId)](#M-Dysnomia-Common-BlizzardWebAPI-Starcraft2Community-GetGrandmasterLeaderboard-System-String,System-String,System-Int32- 'Dysnomia.Common.BlizzardWebAPI.Starcraft2Community.GetGrandmasterLeaderboard(System.String,System.String,System.Int32)')
  - [GetGrandmasterLeaderboard(accessToken,region,regionId)](#M-Dysnomia-Common-BlizzardWebAPI-Starcraft2Community-GetGrandmasterLeaderboard-System-String,Dysnomia-Common-BlizzardWebAPI-Enums-RegionEnum,Dysnomia-Common-BlizzardWebAPI-Enums-StarCraft2RegionEnum- 'Dysnomia.Common.BlizzardWebAPI.Starcraft2Community.GetGrandmasterLeaderboard(System.String,Dysnomia.Common.BlizzardWebAPI.Enums.RegionEnum,Dysnomia.Common.BlizzardWebAPI.Enums.StarCraft2RegionEnum)')
  - [GetLadderSeason(accessToken,region,regionId)](#M-Dysnomia-Common-BlizzardWebAPI-Starcraft2Community-GetLadderSeason-System-String,System-String,System-Int32- 'Dysnomia.Common.BlizzardWebAPI.Starcraft2Community.GetLadderSeason(System.String,System.String,System.Int32)')
  - [GetLadderSeason(accessToken,region,regionId)](#M-Dysnomia-Common-BlizzardWebAPI-Starcraft2Community-GetLadderSeason-System-String,Dysnomia-Common-BlizzardWebAPI-Enums-RegionEnum,Dysnomia-Common-BlizzardWebAPI-Enums-StarCraft2RegionEnum- 'Dysnomia.Common.BlizzardWebAPI.Starcraft2Community.GetLadderSeason(System.String,Dysnomia.Common.BlizzardWebAPI.Enums.RegionEnum,Dysnomia.Common.BlizzardWebAPI.Enums.StarCraft2RegionEnum)')
  - [GetMetadataProfile(accessToken,region,regionId,realmId,profileId,locale)](#M-Dysnomia-Common-BlizzardWebAPI-Starcraft2Community-GetMetadataProfile-System-String,System-String,System-Int32,System-Int32,System-UInt64,System-String- 'Dysnomia.Common.BlizzardWebAPI.Starcraft2Community.GetMetadataProfile(System.String,System.String,System.Int32,System.Int32,System.UInt64,System.String)')
  - [GetMetadataProfile(accessToken,region,regionId,realmId,profileId,locale)](#M-Dysnomia-Common-BlizzardWebAPI-Starcraft2Community-GetMetadataProfile-System-String,Dysnomia-Common-BlizzardWebAPI-Enums-RegionEnum,Dysnomia-Common-BlizzardWebAPI-Enums-StarCraft2RegionEnum,Dysnomia-Common-BlizzardWebAPI-Enums-StarCraft2RealmEnum,System-UInt64,System-String- 'Dysnomia.Common.BlizzardWebAPI.Starcraft2Community.GetMetadataProfile(System.String,Dysnomia.Common.BlizzardWebAPI.Enums.RegionEnum,Dysnomia.Common.BlizzardWebAPI.Enums.StarCraft2RegionEnum,Dysnomia.Common.BlizzardWebAPI.Enums.StarCraft2RealmEnum,System.UInt64,System.String)')
  - [GetPlayerAccount(accessToken,region,accountId)](#M-Dysnomia-Common-BlizzardWebAPI-Starcraft2Community-GetPlayerAccount-System-String,System-String,System-UInt64- 'Dysnomia.Common.BlizzardWebAPI.Starcraft2Community.GetPlayerAccount(System.String,System.String,System.UInt64)')
  - [GetPlayerAccount(accessToken,region,accountId)](#M-Dysnomia-Common-BlizzardWebAPI-Starcraft2Community-GetPlayerAccount-System-String,Dysnomia-Common-BlizzardWebAPI-Enums-RegionEnum,System-UInt64- 'Dysnomia.Common.BlizzardWebAPI.Starcraft2Community.GetPlayerAccount(System.String,Dysnomia.Common.BlizzardWebAPI.Enums.RegionEnum,System.UInt64)')
  - [GetProfile(accessToken,region,regionId,realmId,profileId,locale)](#M-Dysnomia-Common-BlizzardWebAPI-Starcraft2Community-GetProfile-System-String,System-String,System-Int32,System-Int32,System-UInt64,System-String- 'Dysnomia.Common.BlizzardWebAPI.Starcraft2Community.GetProfile(System.String,System.String,System.Int32,System.Int32,System.UInt64,System.String)')
  - [GetProfile(accessToken,region,regionId,realmId,profileId,locale)](#M-Dysnomia-Common-BlizzardWebAPI-Starcraft2Community-GetProfile-System-String,Dysnomia-Common-BlizzardWebAPI-Enums-RegionEnum,Dysnomia-Common-BlizzardWebAPI-Enums-StarCraft2RegionEnum,Dysnomia-Common-BlizzardWebAPI-Enums-StarCraft2RealmEnum,System-UInt64,System-String- 'Dysnomia.Common.BlizzardWebAPI.Starcraft2Community.GetProfile(System.String,Dysnomia.Common.BlizzardWebAPI.Enums.RegionEnum,Dysnomia.Common.BlizzardWebAPI.Enums.StarCraft2RegionEnum,Dysnomia.Common.BlizzardWebAPI.Enums.StarCraft2RealmEnum,System.UInt64,System.String)')
  - [GetProfileLadder(accessToken,region,regionId,realmId,profileId,ladderId,locale)](#M-Dysnomia-Common-BlizzardWebAPI-Starcraft2Community-GetProfileLadder-System-String,System-String,System-Int32,System-Int32,System-UInt64,System-Int32,System-String- 'Dysnomia.Common.BlizzardWebAPI.Starcraft2Community.GetProfileLadder(System.String,System.String,System.Int32,System.Int32,System.UInt64,System.Int32,System.String)')
  - [GetProfileLadder(accessToken,region,regionId,realmId,profileId,ladderId,locale)](#M-Dysnomia-Common-BlizzardWebAPI-Starcraft2Community-GetProfileLadder-System-String,Dysnomia-Common-BlizzardWebAPI-Enums-RegionEnum,Dysnomia-Common-BlizzardWebAPI-Enums-StarCraft2RegionEnum,Dysnomia-Common-BlizzardWebAPI-Enums-StarCraft2RealmEnum,System-UInt64,System-Int32,System-String- 'Dysnomia.Common.BlizzardWebAPI.Starcraft2Community.GetProfileLadder(System.String,Dysnomia.Common.BlizzardWebAPI.Enums.RegionEnum,Dysnomia.Common.BlizzardWebAPI.Enums.StarCraft2RegionEnum,Dysnomia.Common.BlizzardWebAPI.Enums.StarCraft2RealmEnum,System.UInt64,System.Int32,System.String)')
  - [GetProfileLadderSummary(accessToken,region,regionId,realmId,profileId,locale)](#M-Dysnomia-Common-BlizzardWebAPI-Starcraft2Community-GetProfileLadderSummary-System-String,System-String,System-Int32,System-Int32,System-UInt64,System-String- 'Dysnomia.Common.BlizzardWebAPI.Starcraft2Community.GetProfileLadderSummary(System.String,System.String,System.Int32,System.Int32,System.UInt64,System.String)')
  - [GetProfileLadderSummary(accessToken,region,regionId,realmId,profileId,locale)](#M-Dysnomia-Common-BlizzardWebAPI-Starcraft2Community-GetProfileLadderSummary-System-String,Dysnomia-Common-BlizzardWebAPI-Enums-RegionEnum,Dysnomia-Common-BlizzardWebAPI-Enums-StarCraft2RegionEnum,Dysnomia-Common-BlizzardWebAPI-Enums-StarCraft2RealmEnum,System-UInt64,System-String- 'Dysnomia.Common.BlizzardWebAPI.Starcraft2Community.GetProfileLadderSummary(System.String,Dysnomia.Common.BlizzardWebAPI.Enums.RegionEnum,Dysnomia.Common.BlizzardWebAPI.Enums.StarCraft2RegionEnum,Dysnomia.Common.BlizzardWebAPI.Enums.StarCraft2RealmEnum,System.UInt64,System.String)')
  - [GetStaticProfile(accessToken,region,regionId,locale)](#M-Dysnomia-Common-BlizzardWebAPI-Starcraft2Community-GetStaticProfile-System-String,System-String,System-Int32,System-String- 'Dysnomia.Common.BlizzardWebAPI.Starcraft2Community.GetStaticProfile(System.String,System.String,System.Int32,System.String)')
  - [GetStaticProfile(accessToken,region,regionId,locale)](#M-Dysnomia-Common-BlizzardWebAPI-Starcraft2Community-GetStaticProfile-System-String,Dysnomia-Common-BlizzardWebAPI-Enums-RegionEnum,Dysnomia-Common-BlizzardWebAPI-Enums-StarCraft2RegionEnum,System-String- 'Dysnomia.Common.BlizzardWebAPI.Starcraft2Community.GetStaticProfile(System.String,Dysnomia.Common.BlizzardWebAPI.Enums.RegionEnum,Dysnomia.Common.BlizzardWebAPI.Enums.StarCraft2RegionEnum,System.String)')
- [TokenQuerier](#T-Dysnomia-Common-BlizzardWebAPI-TokenQuerier 'Dysnomia.Common.BlizzardWebAPI.TokenQuerier')
  - [GetAuthorizationCodeFlow(authorization_code,scope)](#M-Dysnomia-Common-BlizzardWebAPI-TokenQuerier-GetAuthorizationCodeFlow-System-String,System-String- 'Dysnomia.Common.BlizzardWebAPI.TokenQuerier.GetAuthorizationCodeFlow(System.String,System.String)')
  - [GetClientCredentialFlow()](#M-Dysnomia-Common-BlizzardWebAPI-TokenQuerier-GetClientCredentialFlow 'Dysnomia.Common.BlizzardWebAPI.TokenQuerier.GetClientCredentialFlow')

<a name='T-Dysnomia-Common-BlizzardWebAPI-Diablo3Community'></a>
## Diablo3Community `type`

##### Namespace

Dysnomia.Common.BlizzardWebAPI

##### Summary

Diablo III community APIs provide endpoints for Diablo III player profiles.
https://develop.battle.net/documentation/diablo-3/community-apis

<a name='M-Dysnomia-Common-BlizzardWebAPI-Diablo3Community-GetAct-System-String,System-String,System-Int32,System-String-'></a>
### GetAct(accessToken,region,actId,locale) `method`

##### Summary

Returns a single act by ID.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| accessToken | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Client credential flow access token |
| region | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The region of the data to retrieve. |
| actId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The ID of the act to retrieve. |
| locale | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The locale to reflect in localized data. |

<a name='M-Dysnomia-Common-BlizzardWebAPI-Diablo3Community-GetAct-System-String,Dysnomia-Common-BlizzardWebAPI-Enums-RegionEnum,System-Int32,System-String-'></a>
### GetAct(accessToken,region,actId,locale) `method`

##### Summary

Returns a single act by ID.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| accessToken | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Client credential flow access token |
| region | [Dysnomia.Common.BlizzardWebAPI.Enums.RegionEnum](#T-Dysnomia-Common-BlizzardWebAPI-Enums-RegionEnum 'Dysnomia.Common.BlizzardWebAPI.Enums.RegionEnum') | The region of the data to retrieve. |
| actId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The ID of the act to retrieve. |
| locale | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The locale to reflect in localized data. |

<a name='M-Dysnomia-Common-BlizzardWebAPI-Diablo3Community-GetActIndex-System-String,System-String,System-String-'></a>
### GetActIndex(accessToken,region,locale) `method`

##### Summary

Returns an index of acts.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| accessToken | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Client credential flow access token |
| region | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The region of the data to retrieve. |
| locale | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The locale to reflect in localized data. |

<a name='M-Dysnomia-Common-BlizzardWebAPI-Diablo3Community-GetActIndex-System-String,Dysnomia-Common-BlizzardWebAPI-Enums-RegionEnum,System-String-'></a>
### GetActIndex(accessToken,region,locale) `method`

##### Summary

Returns an index of acts.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| accessToken | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Client credential flow access token |
| region | [Dysnomia.Common.BlizzardWebAPI.Enums.RegionEnum](#T-Dysnomia-Common-BlizzardWebAPI-Enums-RegionEnum 'Dysnomia.Common.BlizzardWebAPI.Enums.RegionEnum') | The region of the data to retrieve. |
| locale | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The locale to reflect in localized data. |

<a name='M-Dysnomia-Common-BlizzardWebAPI-Diablo3Community-GetArtisan-System-String,System-String,System-String,System-String-'></a>
### GetArtisan(accessToken,region,artisanSlug,locale) `method`

##### Summary

Returns a single artisan by slug.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| accessToken | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Client credential flow access token |
| region | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The region of the data to retrieve. |
| artisanSlug | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The slug of the artisan to retrieve. |
| locale | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The locale to reflect in localized data. |

<a name='M-Dysnomia-Common-BlizzardWebAPI-Diablo3Community-GetArtisan-System-String,Dysnomia-Common-BlizzardWebAPI-Enums-RegionEnum,Dysnomia-Common-BlizzardWebAPI-Enums-Artisan,System-String-'></a>
### GetArtisan(accessToken,region,artisanSlug,locale) `method`

##### Summary

Returns a single artisan by slug.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| accessToken | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Client credential flow access token |
| region | [Dysnomia.Common.BlizzardWebAPI.Enums.RegionEnum](#T-Dysnomia-Common-BlizzardWebAPI-Enums-RegionEnum 'Dysnomia.Common.BlizzardWebAPI.Enums.RegionEnum') | The region of the data to retrieve. |
| artisanSlug | [Dysnomia.Common.BlizzardWebAPI.Enums.Artisan](#T-Dysnomia-Common-BlizzardWebAPI-Enums-Artisan 'Dysnomia.Common.BlizzardWebAPI.Enums.Artisan') | The slug of the artisan to retrieve. |
| locale | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The locale to reflect in localized data. |

<a name='M-Dysnomia-Common-BlizzardWebAPI-Diablo3Community-GetFollower-System-String,System-String,System-String,System-String-'></a>
### GetFollower(accessToken,region,followerSlug,locale) `method`

##### Summary

Returns a single follower by slug.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| accessToken | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Client credential flow access token |
| region | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The region of the data to retrieve. |
| followerSlug | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The slug of the follower to retrieve. |
| locale | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The locale to reflect in localized data. |

<a name='M-Dysnomia-Common-BlizzardWebAPI-Diablo3Community-GetFollower-System-String,Dysnomia-Common-BlizzardWebAPI-Enums-RegionEnum,Dysnomia-Common-BlizzardWebAPI-Enums-Follower,System-String-'></a>
### GetFollower(accessToken,region,followerSlug,locale) `method`

##### Summary

Returns a single follower by slug.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| accessToken | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Client credential flow access token |
| region | [Dysnomia.Common.BlizzardWebAPI.Enums.RegionEnum](#T-Dysnomia-Common-BlizzardWebAPI-Enums-RegionEnum 'Dysnomia.Common.BlizzardWebAPI.Enums.RegionEnum') | The region of the data to retrieve. |
| followerSlug | [Dysnomia.Common.BlizzardWebAPI.Enums.Follower](#T-Dysnomia-Common-BlizzardWebAPI-Enums-Follower 'Dysnomia.Common.BlizzardWebAPI.Enums.Follower') | The slug of the follower to retrieve. |
| locale | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The locale to reflect in localized data. |

<a name='M-Dysnomia-Common-BlizzardWebAPI-Diablo3Community-GetImage-Dysnomia-Common-BlizzardWebAPI-Enums-Diablo3ImageType,System-String,System-String-'></a>
### GetImage(type,size,icon) `method`

##### Summary

Get image URL from type, size and icon in blizzard CDN.
Warning: this CDN only supports HTTP, not HTTPS

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| type | [Dysnomia.Common.BlizzardWebAPI.Enums.Diablo3ImageType](#T-Dysnomia-Common-BlizzardWebAPI-Enums-Diablo3ImageType 'Dysnomia.Common.BlizzardWebAPI.Enums.Diablo3ImageType') | The image type (items or skills) |
| size | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The size: for items must either be small or large; for skills must be 21, 42, or 64 (These values refer to the image size in pixels). |
| icon | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Icon name without extension |

<a name='M-Dysnomia-Common-BlizzardWebAPI-Diablo3Community-GetRecipe-System-String,System-String,System-String,System-String,System-String-'></a>
### GetRecipe(accessToken,region,artisanSlug,recipeSlug,locale) `method`

##### Summary

Returns a single recipe by slug for the specified artisan.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| accessToken | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Client credential flow access token |
| region | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The region of the data to retrieve. |
| artisanSlug | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The slug of the artisan to retrieve. |
| recipeSlug | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The slug of the recipe to retrieve. |
| locale | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The locale to reflect in localized data. |

<a name='M-Dysnomia-Common-BlizzardWebAPI-Diablo3Community-GetRecipe-System-String,Dysnomia-Common-BlizzardWebAPI-Enums-RegionEnum,Dysnomia-Common-BlizzardWebAPI-Enums-Artisan,System-String,System-String-'></a>
### GetRecipe(accessToken,region,artisanSlug,recipeSlug,locale) `method`

##### Summary

Returns a single recipe by slug for the specified artisan.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| accessToken | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Client credential flow access token |
| region | [Dysnomia.Common.BlizzardWebAPI.Enums.RegionEnum](#T-Dysnomia-Common-BlizzardWebAPI-Enums-RegionEnum 'Dysnomia.Common.BlizzardWebAPI.Enums.RegionEnum') | The region of the data to retrieve. |
| artisanSlug | [Dysnomia.Common.BlizzardWebAPI.Enums.Artisan](#T-Dysnomia-Common-BlizzardWebAPI-Enums-Artisan 'Dysnomia.Common.BlizzardWebAPI.Enums.Artisan') | The slug of the artisan to retrieve. |
| recipeSlug | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The slug of the recipe to retrieve. |
| locale | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The locale to reflect in localized data. |

<a name='T-Dysnomia-Common-BlizzardWebAPI-IDiablo3Community'></a>
## IDiablo3Community `type`

##### Namespace

Dysnomia.Common.BlizzardWebAPI

##### Summary

Diablo III community APIs provide endpoints for Diablo III player profiles.
https://develop.battle.net/documentation/diablo-3/community-apis

<a name='M-Dysnomia-Common-BlizzardWebAPI-IDiablo3Community-GetAct-System-String,System-String,System-Int32,System-String-'></a>
### GetAct(accessToken,region,actId,locale) `method`

##### Summary

Returns a single act by ID.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| accessToken | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Client credential flow access token |
| region | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The region of the data to retrieve. |
| actId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The ID of the act to retrieve. |
| locale | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The locale to reflect in localized data. |

<a name='M-Dysnomia-Common-BlizzardWebAPI-IDiablo3Community-GetAct-System-String,Dysnomia-Common-BlizzardWebAPI-Enums-RegionEnum,System-Int32,System-String-'></a>
### GetAct(accessToken,region,actId,locale) `method`

##### Summary

Returns a single act by ID.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| accessToken | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Client credential flow access token |
| region | [Dysnomia.Common.BlizzardWebAPI.Enums.RegionEnum](#T-Dysnomia-Common-BlizzardWebAPI-Enums-RegionEnum 'Dysnomia.Common.BlizzardWebAPI.Enums.RegionEnum') | The region of the data to retrieve. |
| actId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The ID of the act to retrieve. |
| locale | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The locale to reflect in localized data. |

<a name='M-Dysnomia-Common-BlizzardWebAPI-IDiablo3Community-GetActIndex-System-String,System-String,System-String-'></a>
### GetActIndex(accessToken,region,locale) `method`

##### Summary

Returns an index of acts.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| accessToken | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Client credential flow access token |
| region | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The region of the data to retrieve. |
| locale | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The locale to reflect in localized data. |

<a name='M-Dysnomia-Common-BlizzardWebAPI-IDiablo3Community-GetActIndex-System-String,Dysnomia-Common-BlizzardWebAPI-Enums-RegionEnum,System-String-'></a>
### GetActIndex(accessToken,region,locale) `method`

##### Summary

Returns an index of acts.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| accessToken | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Client credential flow access token |
| region | [Dysnomia.Common.BlizzardWebAPI.Enums.RegionEnum](#T-Dysnomia-Common-BlizzardWebAPI-Enums-RegionEnum 'Dysnomia.Common.BlizzardWebAPI.Enums.RegionEnum') | The region of the data to retrieve. |
| locale | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The locale to reflect in localized data. |

<a name='M-Dysnomia-Common-BlizzardWebAPI-IDiablo3Community-GetArtisan-System-String,System-String,System-String,System-String-'></a>
### GetArtisan(accessToken,region,artisanSlug,locale) `method`

##### Summary

Returns a single artisan by slug.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| accessToken | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Client credential flow access token |
| region | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The region of the data to retrieve. |
| artisanSlug | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The slug of the artisan to retrieve. |
| locale | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The locale to reflect in localized data. |

<a name='M-Dysnomia-Common-BlizzardWebAPI-IDiablo3Community-GetArtisan-System-String,Dysnomia-Common-BlizzardWebAPI-Enums-RegionEnum,Dysnomia-Common-BlizzardWebAPI-Enums-Artisan,System-String-'></a>
### GetArtisan(accessToken,region,artisanSlug,locale) `method`

##### Summary

Returns a single artisan by slug.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| accessToken | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Client credential flow access token |
| region | [Dysnomia.Common.BlizzardWebAPI.Enums.RegionEnum](#T-Dysnomia-Common-BlizzardWebAPI-Enums-RegionEnum 'Dysnomia.Common.BlizzardWebAPI.Enums.RegionEnum') | The region of the data to retrieve. |
| artisanSlug | [Dysnomia.Common.BlizzardWebAPI.Enums.Artisan](#T-Dysnomia-Common-BlizzardWebAPI-Enums-Artisan 'Dysnomia.Common.BlizzardWebAPI.Enums.Artisan') | The slug of the artisan to retrieve. |
| locale | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The locale to reflect in localized data. |

<a name='M-Dysnomia-Common-BlizzardWebAPI-IDiablo3Community-GetFollower-System-String,System-String,System-String,System-String-'></a>
### GetFollower(accessToken,region,followerSlug,locale) `method`

##### Summary

Returns a single follower by slug.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| accessToken | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Client credential flow access token |
| region | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The region of the data to retrieve. |
| followerSlug | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The slug of the follower to retrieve. |
| locale | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The locale to reflect in localized data. |

<a name='M-Dysnomia-Common-BlizzardWebAPI-IDiablo3Community-GetFollower-System-String,Dysnomia-Common-BlizzardWebAPI-Enums-RegionEnum,Dysnomia-Common-BlizzardWebAPI-Enums-Follower,System-String-'></a>
### GetFollower(accessToken,region,followerSlug,locale) `method`

##### Summary

Returns a single follower by slug.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| accessToken | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Client credential flow access token |
| region | [Dysnomia.Common.BlizzardWebAPI.Enums.RegionEnum](#T-Dysnomia-Common-BlizzardWebAPI-Enums-RegionEnum 'Dysnomia.Common.BlizzardWebAPI.Enums.RegionEnum') | The region of the data to retrieve. |
| followerSlug | [Dysnomia.Common.BlizzardWebAPI.Enums.Follower](#T-Dysnomia-Common-BlizzardWebAPI-Enums-Follower 'Dysnomia.Common.BlizzardWebAPI.Enums.Follower') | The slug of the follower to retrieve. |
| locale | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The locale to reflect in localized data. |

<a name='M-Dysnomia-Common-BlizzardWebAPI-IDiablo3Community-GetImage-Dysnomia-Common-BlizzardWebAPI-Enums-Diablo3ImageType,System-String,System-String-'></a>
### GetImage(type,size,icon) `method`

##### Summary

Get image URL from type, size and icon in blizzard CDN

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| type | [Dysnomia.Common.BlizzardWebAPI.Enums.Diablo3ImageType](#T-Dysnomia-Common-BlizzardWebAPI-Enums-Diablo3ImageType 'Dysnomia.Common.BlizzardWebAPI.Enums.Diablo3ImageType') | The image type (items or skills) |
| size | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The size: for items must either be small or large; for skills must be 21, 42, or 64 (These values refer to the image size in pixels). |
| icon | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Icon name without extension |

<a name='M-Dysnomia-Common-BlizzardWebAPI-IDiablo3Community-GetRecipe-System-String,System-String,System-String,System-String,System-String-'></a>
### GetRecipe(accessToken,region,artisanSlug,recipeSlug,locale) `method`

##### Summary

Returns a single recipe by slug for the specified artisan.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| accessToken | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Client credential flow access token |
| region | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The region of the data to retrieve. |
| artisanSlug | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The slug of the artisan to retrieve. |
| recipeSlug | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The slug of the recipe to retrieve. |
| locale | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The locale to reflect in localized data. |

<a name='M-Dysnomia-Common-BlizzardWebAPI-IDiablo3Community-GetRecipe-System-String,Dysnomia-Common-BlizzardWebAPI-Enums-RegionEnum,Dysnomia-Common-BlizzardWebAPI-Enums-Artisan,System-String,System-String-'></a>
### GetRecipe(accessToken,region,artisanSlug,recipeSlug,locale) `method`

##### Summary

Returns a single recipe by slug for the specified artisan.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| accessToken | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Client credential flow access token |
| region | [Dysnomia.Common.BlizzardWebAPI.Enums.RegionEnum](#T-Dysnomia-Common-BlizzardWebAPI-Enums-RegionEnum 'Dysnomia.Common.BlizzardWebAPI.Enums.RegionEnum') | The region of the data to retrieve. |
| artisanSlug | [Dysnomia.Common.BlizzardWebAPI.Enums.Artisan](#T-Dysnomia-Common-BlizzardWebAPI-Enums-Artisan 'Dysnomia.Common.BlizzardWebAPI.Enums.Artisan') | The slug of the artisan to retrieve. |
| recipeSlug | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The slug of the recipe to retrieve. |
| locale | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The locale to reflect in localized data. |

<a name='T-Dysnomia-Common-BlizzardWebAPI-ILegacyStarcraft2Community'></a>
## ILegacyStarcraft2Community `type`

##### Namespace

Dysnomia.Common.BlizzardWebAPI

##### Summary

See https://develop.battle.net/documentation/starcraft-2/community-apis, under "Legacy API"

<a name='M-Dysnomia-Common-BlizzardWebAPI-ILegacyStarcraft2Community-GetPlayerProfile-System-String,System-String,System-Int32,System-Int32,System-UInt64-'></a>
### GetPlayerProfile(accessToken,region,regionId,realmId,profileId) `method`

##### Summary

Retrieves data about an individual Starcraft2 profile.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| accessToken | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Credential Code Flow access token |
| region | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | StarCraft II community APIs use the region parameter to set the host region in the Try It feature. Note: {region} does not affect StarCraft II responses, which use the :regionId parameter in requests. |
| regionId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | You can retrieve these parameters by issuing a GetPlayerAccount request. |
| realmId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | You can retrieve these parameters by issuing a GetPlayerAccount request. |
| profileId | [System.UInt64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt64 'System.UInt64') | You can retrieve these parameters by issuing a GetPlayerAccount request. |

<a name='M-Dysnomia-Common-BlizzardWebAPI-ILegacyStarcraft2Community-GetPlayerProfile-System-String,Dysnomia-Common-BlizzardWebAPI-Enums-RegionEnum,Dysnomia-Common-BlizzardWebAPI-Enums-StarCraft2RegionEnum,Dysnomia-Common-BlizzardWebAPI-Enums-StarCraft2RealmEnum,System-UInt64-'></a>
### GetPlayerProfile(accessToken,region,regionId,realmId,profileId) `method`

##### Summary

Retrieves data about an individual Starcraft2 profile.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| accessToken | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Credential Code Flow access token |
| region | [Dysnomia.Common.BlizzardWebAPI.Enums.RegionEnum](#T-Dysnomia-Common-BlizzardWebAPI-Enums-RegionEnum 'Dysnomia.Common.BlizzardWebAPI.Enums.RegionEnum') | StarCraft II community APIs use the region parameter to set the host region in the Try It feature. Note: {region} does not affect StarCraft II responses, which use the :regionId parameter in requests. |
| regionId | [Dysnomia.Common.BlizzardWebAPI.Enums.StarCraft2RegionEnum](#T-Dysnomia-Common-BlizzardWebAPI-Enums-StarCraft2RegionEnum 'Dysnomia.Common.BlizzardWebAPI.Enums.StarCraft2RegionEnum') | You can retrieve these parameters by issuing a GetPlayerAccount request. |
| realmId | [Dysnomia.Common.BlizzardWebAPI.Enums.StarCraft2RealmEnum](#T-Dysnomia-Common-BlizzardWebAPI-Enums-StarCraft2RealmEnum 'Dysnomia.Common.BlizzardWebAPI.Enums.StarCraft2RealmEnum') | You can retrieve these parameters by issuing a GetPlayerAccount request. |
| profileId | [System.UInt64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt64 'System.UInt64') | You can retrieve these parameters by issuing a GetPlayerAccount request. |

<a name='T-Dysnomia-Common-BlizzardWebAPI-IStarcraft2Community'></a>
## IStarcraft2Community `type`

##### Namespace

Dysnomia.Common.BlizzardWebAPI

##### Summary

See https://develop.battle.net/documentation/starcraft-2/community-apis

<a name='M-Dysnomia-Common-BlizzardWebAPI-IStarcraft2Community-GetGrandmasterLeaderboard-System-String,System-String,System-Int32-'></a>
### GetGrandmasterLeaderboard(accessToken,region,regionId) `method`

##### Summary

Returns ladder data for the current season's grandmaster leaderboard.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| accessToken | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Credential Code Flow access token |
| region | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The region of the data to retrieve. |
| regionId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The region for the profile |

<a name='M-Dysnomia-Common-BlizzardWebAPI-IStarcraft2Community-GetGrandmasterLeaderboard-System-String,Dysnomia-Common-BlizzardWebAPI-Enums-RegionEnum,Dysnomia-Common-BlizzardWebAPI-Enums-StarCraft2RegionEnum-'></a>
### GetGrandmasterLeaderboard(accessToken,region,regionId) `method`

##### Summary

Returns ladder data for the current season's grandmaster leaderboard.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| accessToken | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Credential Code Flow access token |
| region | [Dysnomia.Common.BlizzardWebAPI.Enums.RegionEnum](#T-Dysnomia-Common-BlizzardWebAPI-Enums-RegionEnum 'Dysnomia.Common.BlizzardWebAPI.Enums.RegionEnum') | The region of the data to retrieve. |
| regionId | [Dysnomia.Common.BlizzardWebAPI.Enums.StarCraft2RegionEnum](#T-Dysnomia-Common-BlizzardWebAPI-Enums-StarCraft2RegionEnum 'Dysnomia.Common.BlizzardWebAPI.Enums.StarCraft2RegionEnum') | The region for the profile |

<a name='M-Dysnomia-Common-BlizzardWebAPI-IStarcraft2Community-GetLadderSeason-System-String,System-String,System-Int32-'></a>
### GetLadderSeason(accessToken,region,regionId) `method`

##### Summary

Returns data about the current season.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| accessToken | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Credential Code Flow access token |
| region | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The region of the data to retrieve. |
| regionId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The region for the profile |

<a name='M-Dysnomia-Common-BlizzardWebAPI-IStarcraft2Community-GetLadderSeason-System-String,Dysnomia-Common-BlizzardWebAPI-Enums-RegionEnum,Dysnomia-Common-BlizzardWebAPI-Enums-StarCraft2RegionEnum-'></a>
### GetLadderSeason(accessToken,region,regionId) `method`

##### Summary

Returns data about the current season.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| accessToken | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Credential Code Flow access token |
| region | [Dysnomia.Common.BlizzardWebAPI.Enums.RegionEnum](#T-Dysnomia-Common-BlizzardWebAPI-Enums-RegionEnum 'Dysnomia.Common.BlizzardWebAPI.Enums.RegionEnum') | The region of the data to retrieve. |
| regionId | [Dysnomia.Common.BlizzardWebAPI.Enums.StarCraft2RegionEnum](#T-Dysnomia-Common-BlizzardWebAPI-Enums-StarCraft2RegionEnum 'Dysnomia.Common.BlizzardWebAPI.Enums.StarCraft2RegionEnum') | The region for the profile |

<a name='M-Dysnomia-Common-BlizzardWebAPI-IStarcraft2Community-GetMetadataProfile-System-String,System-String,System-Int32,System-Int32,System-UInt64,System-String-'></a>
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

<a name='M-Dysnomia-Common-BlizzardWebAPI-IStarcraft2Community-GetMetadataProfile-System-String,Dysnomia-Common-BlizzardWebAPI-Enums-RegionEnum,Dysnomia-Common-BlizzardWebAPI-Enums-StarCraft2RegionEnum,Dysnomia-Common-BlizzardWebAPI-Enums-StarCraft2RealmEnum,System-UInt64,System-String-'></a>
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

<a name='M-Dysnomia-Common-BlizzardWebAPI-IStarcraft2Community-GetPlayerAccount-System-String,System-String,System-UInt64-'></a>
### GetPlayerAccount(accessToken,region,accountId) `method`

##### Summary

Returns metadata for an individual's account.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| accessToken | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Credential Code Flow access token |
| region | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The region of the data to retrieve. |
| accountId | [System.UInt64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt64 'System.UInt64') | The ID of the account for which to retrieve data. |

<a name='M-Dysnomia-Common-BlizzardWebAPI-IStarcraft2Community-GetPlayerAccount-System-String,Dysnomia-Common-BlizzardWebAPI-Enums-RegionEnum,System-UInt64-'></a>
### GetPlayerAccount(accessToken,region,accountId) `method`

##### Summary

Returns metadata for an individual's account.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| accessToken | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Credential Code Flow access token |
| region | [Dysnomia.Common.BlizzardWebAPI.Enums.RegionEnum](#T-Dysnomia-Common-BlizzardWebAPI-Enums-RegionEnum 'Dysnomia.Common.BlizzardWebAPI.Enums.RegionEnum') | The region of the data to retrieve. |
| accountId | [System.UInt64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt64 'System.UInt64') | The ID of the account for which to retrieve data. |

<a name='M-Dysnomia-Common-BlizzardWebAPI-IStarcraft2Community-GetProfile-System-String,System-String,System-Int32,System-Int32,System-UInt64,System-String-'></a>
### GetProfile(accessToken,region,regionId,realmId,profileId,locale) `method`

##### Summary

Returns data about an individual Starcraft2 profile.

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

<a name='M-Dysnomia-Common-BlizzardWebAPI-IStarcraft2Community-GetProfile-System-String,Dysnomia-Common-BlizzardWebAPI-Enums-RegionEnum,Dysnomia-Common-BlizzardWebAPI-Enums-StarCraft2RegionEnum,Dysnomia-Common-BlizzardWebAPI-Enums-StarCraft2RealmEnum,System-UInt64,System-String-'></a>
### GetProfile(accessToken,region,regionId,realmId,profileId,locale) `method`

##### Summary

Returns data about an individual Starcraft2 profile.

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

<a name='M-Dysnomia-Common-BlizzardWebAPI-IStarcraft2Community-GetProfileLadder-System-String,System-String,System-Int32,System-Int32,System-UInt64,System-Int32,System-String-'></a>
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

<a name='M-Dysnomia-Common-BlizzardWebAPI-IStarcraft2Community-GetProfileLadder-System-String,Dysnomia-Common-BlizzardWebAPI-Enums-RegionEnum,Dysnomia-Common-BlizzardWebAPI-Enums-StarCraft2RegionEnum,Dysnomia-Common-BlizzardWebAPI-Enums-StarCraft2RealmEnum,System-UInt64,System-Int32,System-String-'></a>
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

<a name='M-Dysnomia-Common-BlizzardWebAPI-IStarcraft2Community-GetProfileLadderSummary-System-String,System-String,System-Int32,System-Int32,System-UInt64,System-String-'></a>
### GetProfileLadderSummary(accessToken,region,regionId,realmId,profileId,locale) `method`

##### Summary

Returns a ladder summary for an individual Starcraft2 profile.

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

<a name='M-Dysnomia-Common-BlizzardWebAPI-IStarcraft2Community-GetProfileLadderSummary-System-String,Dysnomia-Common-BlizzardWebAPI-Enums-RegionEnum,Dysnomia-Common-BlizzardWebAPI-Enums-StarCraft2RegionEnum,Dysnomia-Common-BlizzardWebAPI-Enums-StarCraft2RealmEnum,System-UInt64,System-String-'></a>
### GetProfileLadderSummary(accessToken,region,regionId,realmId,profileId,locale) `method`

##### Summary

Returns a ladder summary for an individual Starcraft2 profile.

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

<a name='M-Dysnomia-Common-BlizzardWebAPI-IStarcraft2Community-GetStaticProfile-System-String,System-String,System-Int32,System-String-'></a>
### GetStaticProfile(accessToken,region,regionId,locale) `method`

##### Summary

Returns all static Starcraft2 profile data (achievements, categories, criteria, and rewards).

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| accessToken | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Credential Code Flow access token |
| region | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The region of the data to retrieve. |
| regionId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The region for the profile |
| locale | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The locale to reflect in localized data. |

<a name='M-Dysnomia-Common-BlizzardWebAPI-IStarcraft2Community-GetStaticProfile-System-String,Dysnomia-Common-BlizzardWebAPI-Enums-RegionEnum,Dysnomia-Common-BlizzardWebAPI-Enums-StarCraft2RegionEnum,System-String-'></a>
### GetStaticProfile(accessToken,region,regionId,locale) `method`

##### Summary

Returns all static Starcraft2 profile data (achievements, categories, criteria, and rewards).

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| accessToken | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Credential Code Flow access token |
| region | [Dysnomia.Common.BlizzardWebAPI.Enums.RegionEnum](#T-Dysnomia-Common-BlizzardWebAPI-Enums-RegionEnum 'Dysnomia.Common.BlizzardWebAPI.Enums.RegionEnum') | The region of the data to retrieve. |
| regionId | [Dysnomia.Common.BlizzardWebAPI.Enums.StarCraft2RegionEnum](#T-Dysnomia-Common-BlizzardWebAPI-Enums-StarCraft2RegionEnum 'Dysnomia.Common.BlizzardWebAPI.Enums.StarCraft2RegionEnum') | The region for the profile |
| locale | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The locale to reflect in localized data. |

<a name='T-Dysnomia-Common-BlizzardWebAPI-LegacyStarcraft2Community'></a>
## LegacyStarcraft2Community `type`

##### Namespace

Dysnomia.Common.BlizzardWebAPI

##### Summary

See https://develop.battle.net/documentation/starcraft-2/community-apis, under "Legacy API"

<a name='M-Dysnomia-Common-BlizzardWebAPI-LegacyStarcraft2Community-GetPlayerProfile-System-String,System-String,System-Int32,System-Int32,System-UInt64-'></a>
### GetPlayerProfile(accessToken,region,regionId,realmId,profileId) `method`

##### Summary

Retrieves data about an individual Starcraft2 profile.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| accessToken | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Credential Code Flow access token |
| region | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | StarCraft II community APIs use the region parameter to set the host region in the Try It feature. Note: {region} does not affect StarCraft II responses, which use the :regionId parameter in requests. |
| regionId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | You can retrieve these parameters by issuing a GetPlayerAccount request. |
| realmId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | You can retrieve these parameters by issuing a GetPlayerAccount request. |
| profileId | [System.UInt64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt64 'System.UInt64') | You can retrieve these parameters by issuing a GetPlayerAccount request. |

<a name='M-Dysnomia-Common-BlizzardWebAPI-LegacyStarcraft2Community-GetPlayerProfile-System-String,Dysnomia-Common-BlizzardWebAPI-Enums-RegionEnum,Dysnomia-Common-BlizzardWebAPI-Enums-StarCraft2RegionEnum,Dysnomia-Common-BlizzardWebAPI-Enums-StarCraft2RealmEnum,System-UInt64-'></a>
### GetPlayerProfile(accessToken,region,regionId,realmId,profileId) `method`

##### Summary

Retrieves data about an individual Starcraft2 profile.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| accessToken | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Credential Code Flow access token |
| region | [Dysnomia.Common.BlizzardWebAPI.Enums.RegionEnum](#T-Dysnomia-Common-BlizzardWebAPI-Enums-RegionEnum 'Dysnomia.Common.BlizzardWebAPI.Enums.RegionEnum') | StarCraft II community APIs use the region parameter to set the host region in the Try It feature. Note: {region} does not affect StarCraft II responses, which use the :regionId parameter in requests. |
| regionId | [Dysnomia.Common.BlizzardWebAPI.Enums.StarCraft2RegionEnum](#T-Dysnomia-Common-BlizzardWebAPI-Enums-StarCraft2RegionEnum 'Dysnomia.Common.BlizzardWebAPI.Enums.StarCraft2RegionEnum') | You can retrieve these parameters by issuing a GetPlayerAccount request. |
| realmId | [Dysnomia.Common.BlizzardWebAPI.Enums.StarCraft2RealmEnum](#T-Dysnomia-Common-BlizzardWebAPI-Enums-StarCraft2RealmEnum 'Dysnomia.Common.BlizzardWebAPI.Enums.StarCraft2RealmEnum') | You can retrieve these parameters by issuing a GetPlayerAccount request. |
| profileId | [System.UInt64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt64 'System.UInt64') | You can retrieve these parameters by issuing a GetPlayerAccount request. |

<a name='T-Dysnomia-Common-BlizzardWebAPI-Starcraft2Community'></a>
## Starcraft2Community `type`

##### Namespace

Dysnomia.Common.BlizzardWebAPI

##### Summary

See https://develop.battle.net/documentation/starcraft-2/community-apis

<a name='M-Dysnomia-Common-BlizzardWebAPI-Starcraft2Community-GetGrandmasterLeaderboard-System-String,System-String,System-Int32-'></a>
### GetGrandmasterLeaderboard(accessToken,region,regionId) `method`

##### Summary

Returns ladder data for the current season's grandmaster leaderboard.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| accessToken | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Credential Code Flow access token |
| region | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The region of the data to retrieve. |
| regionId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The region for the profile |

<a name='M-Dysnomia-Common-BlizzardWebAPI-Starcraft2Community-GetGrandmasterLeaderboard-System-String,Dysnomia-Common-BlizzardWebAPI-Enums-RegionEnum,Dysnomia-Common-BlizzardWebAPI-Enums-StarCraft2RegionEnum-'></a>
### GetGrandmasterLeaderboard(accessToken,region,regionId) `method`

##### Summary

Returns ladder data for the current season's grandmaster leaderboard.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| accessToken | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Credential Code Flow access token |
| region | [Dysnomia.Common.BlizzardWebAPI.Enums.RegionEnum](#T-Dysnomia-Common-BlizzardWebAPI-Enums-RegionEnum 'Dysnomia.Common.BlizzardWebAPI.Enums.RegionEnum') | The region of the data to retrieve. |
| regionId | [Dysnomia.Common.BlizzardWebAPI.Enums.StarCraft2RegionEnum](#T-Dysnomia-Common-BlizzardWebAPI-Enums-StarCraft2RegionEnum 'Dysnomia.Common.BlizzardWebAPI.Enums.StarCraft2RegionEnum') | The region for the profile |

<a name='M-Dysnomia-Common-BlizzardWebAPI-Starcraft2Community-GetLadderSeason-System-String,System-String,System-Int32-'></a>
### GetLadderSeason(accessToken,region,regionId) `method`

##### Summary

Returns data about the current season.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| accessToken | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Credential Code Flow access token |
| region | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The region of the data to retrieve. |
| regionId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The region for the profile |

<a name='M-Dysnomia-Common-BlizzardWebAPI-Starcraft2Community-GetLadderSeason-System-String,Dysnomia-Common-BlizzardWebAPI-Enums-RegionEnum,Dysnomia-Common-BlizzardWebAPI-Enums-StarCraft2RegionEnum-'></a>
### GetLadderSeason(accessToken,region,regionId) `method`

##### Summary

Returns data about the current season.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| accessToken | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Credential Code Flow access token |
| region | [Dysnomia.Common.BlizzardWebAPI.Enums.RegionEnum](#T-Dysnomia-Common-BlizzardWebAPI-Enums-RegionEnum 'Dysnomia.Common.BlizzardWebAPI.Enums.RegionEnum') | The region of the data to retrieve. |
| regionId | [Dysnomia.Common.BlizzardWebAPI.Enums.StarCraft2RegionEnum](#T-Dysnomia-Common-BlizzardWebAPI-Enums-StarCraft2RegionEnum 'Dysnomia.Common.BlizzardWebAPI.Enums.StarCraft2RegionEnum') | The region for the profile |

<a name='M-Dysnomia-Common-BlizzardWebAPI-Starcraft2Community-GetMetadataProfile-System-String,System-String,System-Int32,System-Int32,System-UInt64,System-String-'></a>
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

<a name='M-Dysnomia-Common-BlizzardWebAPI-Starcraft2Community-GetMetadataProfile-System-String,Dysnomia-Common-BlizzardWebAPI-Enums-RegionEnum,Dysnomia-Common-BlizzardWebAPI-Enums-StarCraft2RegionEnum,Dysnomia-Common-BlizzardWebAPI-Enums-StarCraft2RealmEnum,System-UInt64,System-String-'></a>
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

<a name='M-Dysnomia-Common-BlizzardWebAPI-Starcraft2Community-GetPlayerAccount-System-String,System-String,System-UInt64-'></a>
### GetPlayerAccount(accessToken,region,accountId) `method`

##### Summary

Returns metadata for an individual's account.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| accessToken | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Credential Code Flow access token |
| region | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The region of the data to retrieve. |
| accountId | [System.UInt64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt64 'System.UInt64') | The ID of the account for which to retrieve data. |

<a name='M-Dysnomia-Common-BlizzardWebAPI-Starcraft2Community-GetPlayerAccount-System-String,Dysnomia-Common-BlizzardWebAPI-Enums-RegionEnum,System-UInt64-'></a>
### GetPlayerAccount(accessToken,region,accountId) `method`

##### Summary

Returns metadata for an individual's account.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| accessToken | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Credential Code Flow access token |
| region | [Dysnomia.Common.BlizzardWebAPI.Enums.RegionEnum](#T-Dysnomia-Common-BlizzardWebAPI-Enums-RegionEnum 'Dysnomia.Common.BlizzardWebAPI.Enums.RegionEnum') | The region of the data to retrieve. |
| accountId | [System.UInt64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt64 'System.UInt64') | The ID of the account for which to retrieve data. |

<a name='M-Dysnomia-Common-BlizzardWebAPI-Starcraft2Community-GetProfile-System-String,System-String,System-Int32,System-Int32,System-UInt64,System-String-'></a>
### GetProfile(accessToken,region,regionId,realmId,profileId,locale) `method`

##### Summary

Returns data about an individual Starcraft2 profile.

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

<a name='M-Dysnomia-Common-BlizzardWebAPI-Starcraft2Community-GetProfile-System-String,Dysnomia-Common-BlizzardWebAPI-Enums-RegionEnum,Dysnomia-Common-BlizzardWebAPI-Enums-StarCraft2RegionEnum,Dysnomia-Common-BlizzardWebAPI-Enums-StarCraft2RealmEnum,System-UInt64,System-String-'></a>
### GetProfile(accessToken,region,regionId,realmId,profileId,locale) `method`

##### Summary

Returns data about an individual Starcraft2 profile.

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

<a name='M-Dysnomia-Common-BlizzardWebAPI-Starcraft2Community-GetProfileLadder-System-String,System-String,System-Int32,System-Int32,System-UInt64,System-Int32,System-String-'></a>
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

<a name='M-Dysnomia-Common-BlizzardWebAPI-Starcraft2Community-GetProfileLadder-System-String,Dysnomia-Common-BlizzardWebAPI-Enums-RegionEnum,Dysnomia-Common-BlizzardWebAPI-Enums-StarCraft2RegionEnum,Dysnomia-Common-BlizzardWebAPI-Enums-StarCraft2RealmEnum,System-UInt64,System-Int32,System-String-'></a>
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

<a name='M-Dysnomia-Common-BlizzardWebAPI-Starcraft2Community-GetProfileLadderSummary-System-String,System-String,System-Int32,System-Int32,System-UInt64,System-String-'></a>
### GetProfileLadderSummary(accessToken,region,regionId,realmId,profileId,locale) `method`

##### Summary

Returns a ladder summary for an individual Starcraft2 profile.

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

<a name='M-Dysnomia-Common-BlizzardWebAPI-Starcraft2Community-GetProfileLadderSummary-System-String,Dysnomia-Common-BlizzardWebAPI-Enums-RegionEnum,Dysnomia-Common-BlizzardWebAPI-Enums-StarCraft2RegionEnum,Dysnomia-Common-BlizzardWebAPI-Enums-StarCraft2RealmEnum,System-UInt64,System-String-'></a>
### GetProfileLadderSummary(accessToken,region,regionId,realmId,profileId,locale) `method`

##### Summary

Returns a ladder summary for an individual Starcraft2 profile.

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

<a name='M-Dysnomia-Common-BlizzardWebAPI-Starcraft2Community-GetStaticProfile-System-String,System-String,System-Int32,System-String-'></a>
### GetStaticProfile(accessToken,region,regionId,locale) `method`

##### Summary

Returns all static Starcraft2 profile data (achievements, categories, criteria, and rewards).

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| accessToken | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Credential Code Flow access token |
| region | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The region of the data to retrieve. |
| regionId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The region for the profile |
| locale | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The locale to reflect in localized data. |

<a name='M-Dysnomia-Common-BlizzardWebAPI-Starcraft2Community-GetStaticProfile-System-String,Dysnomia-Common-BlizzardWebAPI-Enums-RegionEnum,Dysnomia-Common-BlizzardWebAPI-Enums-StarCraft2RegionEnum,System-String-'></a>
### GetStaticProfile(accessToken,region,regionId,locale) `method`

##### Summary

Returns all static Starcraft2 profile data (achievements, categories, criteria, and rewards).

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
