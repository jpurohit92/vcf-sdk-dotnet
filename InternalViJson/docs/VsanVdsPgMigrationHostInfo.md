# Vcenter.ViJson.OpenApi.Model.VsanVdsPgMigrationHostInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Host** | [**ManagedObjectReference**](ManagedObjectReference.md) | Host reference of the host that is being migrated.  Refers instance of *HostSystem*.  | 
**Hostname** | **string** | Hostname of the host that is being migrated.  | 
**VmknicDevices** | **List&lt;string&gt;** | List of vmknic device names which are current consumer of the VSS portgroup that will be migrated.  | [optional] 
**VmVnics** | [**List&lt;VsanVdsPgMigrationVmInfo&gt;**](VsanVdsPgMigrationVmInfo.md) | List of VMs and their vNics which are current consumer of the VSS portgroup that will be migrated.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

