# Vcenter.ViJson.OpenApi.Model.VsanIscsiHomeObjectSpec

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**StoragePolicy** | [**VirtualMachineProfileSpec**](VirtualMachineProfileSpec.md) | Default storage policy for the home object, which acts as a descriptor for the targets.  If it is not specified, vSAN datastore vmnamespace policy should be used by default.  | [optional] 
**DefaultConfig** | [**VsanIscsiTargetServiceDefaultConfigSpec**](VsanIscsiTargetServiceDefaultConfigSpec.md) | iSCSI target service default configuration, the networkInterface property in this field is required when create home object.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

