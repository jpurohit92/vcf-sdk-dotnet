# Vcenter.Automation.OpenApi.Model.VstatsAcqSpecsCounterSpec
The Vstats.AcqSpecs.CounterSpec schema designates a counter or counter set in an acquisition specification.  __Warning:__ this schema is available as Technology Preview. These are early access APIs provided to test, automate and provide feedback on the feature. Since this can change based on feedback, VMware does not guarantee backwards compatibility and recommends against using them in production environments. Some Technology Preview APIs might only be applicable to specific environments.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CidMid** | [**VstatsCidMid**](VstatsCidMid.md) | Counter and optional meatadata identifier.  __Warning:__ this property is available as Technology Preview. These are early access APIs provided to test, automate and provide feedback on the feature. Since this can change based on feedback, VMware does not guarantee backwards compatibility and recommends against using them in production environments. Some Technology Preview APIs might only be applicable to specific environments.  When missing or &#x60;null&#x60; the set_id field will be used. | [optional] 
**SetId** | **string** | Counter set identifier  __Warning:__ this property is available as Technology Preview. These are early access APIs provided to test, automate and provide feedback on the feature. Since this can change based on feedback, VMware does not guarantee backwards compatibility and recommends against using them in production environments. Some Technology Preview APIs might only be applicable to specific environments.  When missing or &#x60;null&#x60; the cid_mid field will be used.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.vstats.model.CounterSet&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.vstats.model.CounterSet&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

