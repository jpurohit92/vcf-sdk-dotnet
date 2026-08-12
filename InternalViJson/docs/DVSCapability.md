# Vcenter.ViJson.OpenApi.Model.DVSCapability

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DvsOperationSupported** | **bool** | Indicates whether this switch allows vCenter users to modify the switch configuration at the switch level, except for host member, policy, and scope operations.  | [optional] 
**DvPortGroupOperationSupported** | **bool** | Indicates whether this switch allows vCenter users to modify the switch configuration at the portgroup level, except for host member, policy, and scope operations.  | [optional] 
**DvPortOperationSupported** | **bool** | Indicates whether this switch allows vCenter users to modify the switch configuration at the port level, except for host member, policy, and scope operations.  | [optional] 
**CompatibleHostComponentProductInfo** | [**List&lt;DistributedVirtualSwitchHostProductSpec&gt;**](DistributedVirtualSwitchHostProductSpec.md) | List of host component product information that is compatible with the current switch implementation.  | [optional] 
**FeaturesSupported** | [**DVSFeatureCapability**](DVSFeatureCapability.md) | Indicators for which version-specific distributed virtual switch features are available on this switch.  This information is read-only, with the following exception. For a third-party distributed switch implementation, you can set the property *DVSFeatureCapability*.*DVSFeatureCapability.vmDirectPathGen2Supported* during switch creation or when you call the *DistributedVirtualSwitch.UpdateDvsCapability* method.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

