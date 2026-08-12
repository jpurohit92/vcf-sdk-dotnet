# Vcenter.ViJson.OpenApi.Model.VsanMigrateVmsToVdsRequestType
The parameters of *VsanHostVdsSystem.VsanMigrateVmsToVds*.  This structure may be used only with operations rendered under `/vsan`. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**VmConfigSpecs** | [**List&lt;VsanVmVdsMigrationSpec&gt;**](VsanVmVdsMigrationSpec.md) | VMs to be migrated via associated specs  | 
**VdsUuid** | **string** | UUID of the VDS that is being migrated to.  | 
**TimeoutSec** | **long** | Time in seconds. See above for timeout behavior.  | 
**Revert** | **bool** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

