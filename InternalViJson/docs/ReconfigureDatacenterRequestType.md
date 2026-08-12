# Vcenter.ViJson.OpenApi.Model.ReconfigureDatacenterRequestType
The parameters of *Datacenter.ReconfigureDatacenter_Task*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Spec** | [**DatacenterConfigSpec**](DatacenterConfigSpec.md) | A set of configuration changes to apply to the datacenter. The specification can be a complete set of changes or a partial set of changes, applied incrementally.  | 
**Modify** | **bool** | Flag to specify whether the specification (\&quot;spec\&quot;) should be applied incrementally. If \&quot;modify\&quot; is false and the operation succeeds, then the configuration of the datacenter matches the specification exactly; in this case any unset portions of the specification will result in unset or default portions of the configuration.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

