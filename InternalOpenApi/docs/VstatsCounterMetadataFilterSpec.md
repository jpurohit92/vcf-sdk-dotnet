# Vcenter.Automation.OpenApi.Model.VstatsCounterMetadataFilterSpec
The Vstats.CounterMetadata.FilterSpec schema is used to filter the counter metadata list.  __Warning:__ this schema is available as Technology Preview. These are early access APIs provided to test, automate and provide feedback on the feature. Since this can change based on feedback, VMware does not guarantee backwards compatibility and recommends against using them in production environments. Some Technology Preview APIs might only be applicable to specific environments.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Status** | **string** | Counter edition status.  Possible values:   - &#x60;DEFAULT&#x60;: The counter edition is current and is the default.   - &#x60;CURRENT&#x60;: The counter edition is current. This implies a support commitment.   - &#x60;DEPRECATED&#x60;: The counter edition is deprecated. It will be decommissioned rather soon.   - &#x60;EXPERIMENTAL&#x60;: The counter edition is experimental. Consumers shouldn&#39;t rely on it for the long haul.   - &#x60;REMOVED&#x60;: The counter edition was removed.   For more information see: *Vstats.CounterMetadata.CounterEditionStatus*.  __Warning:__ this property is available as Technology Preview. These are early access APIs provided to test, automate and provide feedback on the feature. Since this can change based on feedback, VMware does not guarantee backwards compatibility and recommends against using them in production environments. Some Technology Preview APIs might only be applicable to specific environments.  When missing or &#x60;null&#x60; no filtering on counter metadata status will be made. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

