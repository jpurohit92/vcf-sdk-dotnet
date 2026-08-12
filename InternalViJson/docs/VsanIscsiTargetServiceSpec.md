# Vcenter.ViJson.OpenApi.Model.VsanIscsiTargetServiceSpec

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DefaultConfig** | [**VsanIscsiTargetServiceDefaultConfigSpec**](VsanIscsiTargetServiceDefaultConfigSpec.md) | vSAN iSCSI target service default configuration.  | [optional] 
**Enabled** | **bool** | Whether vSAN iSCSI target service is enabled.  | [optional] 
**VipConfigs** | [**List&lt;VsanIscsiVipConfigSpec&gt;**](VsanIscsiVipConfigSpec.md) | Virtual IP (VIP) configurations.  Currently, only 1 Virutal IP configuration is allowed.  | [optional] 
**HomeObjectStoragePolicy** | [**VirtualMachineProfileSpec**](VirtualMachineProfileSpec.md) | Default storage policy for the vSAN iSCSI target home object.  If it is not specified, vSAN datastore vmnamespace policy should be used by default.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

