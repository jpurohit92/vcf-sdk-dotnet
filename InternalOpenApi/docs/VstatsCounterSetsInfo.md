# Vcenter.Automation.OpenApi.Model.VstatsCounterSetsInfo
The Vstats.CounterSets.Info schema contains information about a set of counters.  __Warning:__ this schema is available as Technology Preview. These are early access APIs provided to test, automate and provide feedback on the feature. Since this can change based on feedback, VMware does not guarantee backwards compatibility and recommends against using them in production environments. Some Technology Preview APIs might only be applicable to specific environments.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Counter set identifier.  __Warning:__ this property is available as Technology Preview. These are early access APIs provided to test, automate and provide feedback on the feature. Since this can change based on feedback, VMware does not guarantee backwards compatibility and recommends against using them in production environments. Some Technology Preview APIs might only be applicable to specific environments. | 
**Counters** | [**List&lt;VstatsCidMid&gt;**](VstatsCidMid.md) | List of Counter CidMids.  __Warning:__ this property is available as Technology Preview. These are early access APIs provided to test, automate and provide feedback on the feature. Since this can change based on feedback, VMware does not guarantee backwards compatibility and recommends against using them in production environments. Some Technology Preview APIs might only be applicable to specific environments. | 
**UserInfo** | [**VstatsUserInfo**](VstatsUserInfo.md) | Human legible localizable conter set description.  __Warning:__ this property is available as Technology Preview. These are early access APIs provided to test, automate and provide feedback on the feature. Since this can change based on feedback, VMware does not guarantee backwards compatibility and recommends against using them in production environments. Some Technology Preview APIs might only be applicable to specific environments.  In future versions it may be possible to have custom counter sets that lack localizable descriptions. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

