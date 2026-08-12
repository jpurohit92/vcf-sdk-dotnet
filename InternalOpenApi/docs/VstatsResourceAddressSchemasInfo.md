# Vcenter.Automation.OpenApi.Model.VstatsResourceAddressSchemasInfo
The Vstats.ResourceAddressSchemas.Info schema defines addressing schema for a counter. This is set of named placeholders for different resource types. For example a network link between VMs will take two arguments \"source\" and \"destination\" both of type VM. For each argument query capability is defined.  __Warning:__ this schema is available as Technology Preview. These are early access APIs provided to test, automate and provide feedback on the feature. Since this can change based on feedback, VMware does not guarantee backwards compatibility and recommends against using them in production environments. Some Technology Preview APIs might only be applicable to specific environments.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Identifier.  __Warning:__ this property is available as Technology Preview. These are early access APIs provided to test, automate and provide feedback on the feature. Since this can change based on feedback, VMware does not guarantee backwards compatibility and recommends against using them in production environments. Some Technology Preview APIs might only be applicable to specific environments.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.vstats.model.RsrcAddrSchema&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.vstats.model.RsrcAddrSchema&#x60;. | 
**Schema** | [**List&lt;VstatsResourceAddressSchemasResourceIdDefinition&gt;**](VstatsResourceAddressSchemasResourceIdDefinition.md) | List of *Vstats.ResourceAddressSchemas.ResourceIdDefinition*s.  __Warning:__ this property is available as Technology Preview. These are early access APIs provided to test, automate and provide feedback on the feature. Since this can change based on feedback, VMware does not guarantee backwards compatibility and recommends against using them in production environments. Some Technology Preview APIs might only be applicable to specific environments. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

