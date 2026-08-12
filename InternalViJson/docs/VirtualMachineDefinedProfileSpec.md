# Vcenter.ViJson.OpenApi.Model.VirtualMachineDefinedProfileSpec

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ProfileId** | **string** | Storage Policy Profile identification - Should be pbm.profileId but for implementation reasons, could not be.  | 
**ReplicationSpec** | [**ReplicationSpec**](ReplicationSpec.md) | Specification containing replication related parameters, sent to the Replication Data Service provider.  | [optional] 
**ProfileData** | [**VirtualMachineProfileRawData**](VirtualMachineProfileRawData.md) | Profile data sent to the Storage Backend by vSphere.  This data is provided by the SPBM component of the vSphere platform. This field should not be set by Virtual Center users.  | [optional] 
**ProfileParams** | [**List&lt;KeyValue&gt;**](KeyValue.md) | Parameterized Storage Profiles Extra configuration that is not expressed as a capability in the Profile definition.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

