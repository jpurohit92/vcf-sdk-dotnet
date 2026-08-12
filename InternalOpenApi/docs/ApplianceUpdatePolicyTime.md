# Vcenter.Automation.OpenApi.Model.ApplianceUpdatePolicyTime
The Appliance.Update.Policy.Time schema defines weekday and time the automatic check for new updates will be run  This schema was added in __vSphere API 6.7__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Day** | **string** | weekday to check for updates.  Possible values:   - &#x60;MONDAY&#x60;: Monday   - &#x60;TUESDAY&#x60;: Tuesday   - &#x60;WEDNESDAY&#x60;: Wednesday   - &#x60;THURSDAY&#x60;: Thursday   - &#x60;FRIDAY&#x60;: Friday   - &#x60;SATURDAY&#x60;: Saturday   - &#x60;SUNDAY&#x60;: Sunday   For more information see: *Appliance.Update.Policy.DayOfWeek*.  This property was added in __vSphere API 6.7__. | 
**Hour** | **long** | Hour: 0-24  This property was added in __vSphere API 6.7__. | 
**Minute** | **long** | Minute: 0-59  This property was added in __vSphere API 6.7__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

