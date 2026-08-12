# Vcenter.ViJson.OpenApi.Model.VsanVdsPgMigrationSpec

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**VssPgName** | **string** | The original name of the VSS portgroup that is being migrated.  The settings of the hosts tracked in the &#39;hosts&#39; field are the ones that are migrated. Note in case of collisions there will be multiple portgroup migration specs for a single VSS portgroup name. See &#39;collisionRename&#39; field.  | 
**DvPgName** | **string** | The name of the DV portgroup that is being created/migrated to.  | 
**VdsPgSetting** | [**VMwareDVSPortSetting**](VMwareDVSPortSetting.md) | The VDS portgroup configuration of the portgroup to be created.  | 
**VdsPgType** | **string** | Type of portgroup to be created.  | 
**Hosts** | [**List&lt;VsanVdsPgMigrationHostInfo&gt;**](VsanVdsPgMigrationHostInfo.md) | Detailed migration information for each host and the consumers of the portgroup on this host.  | [optional] 
**CollisionRename** | **bool** | If true, the hosts tracked in this pg migration spec have a different portgroup setting spec than other hosts.  In order to not change any settings as part of the migration, the conflict is resolved by creating this additional DVPortgroup under a renamed name (e.g. VssName-2).  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

