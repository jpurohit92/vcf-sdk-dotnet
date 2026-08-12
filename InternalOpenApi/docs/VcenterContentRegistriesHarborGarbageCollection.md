# Vcenter.Automation.OpenApi.Model.VcenterContentRegistriesHarborGarbageCollection
This schema is deprecated as of __vSphere API 8.0.1.00200__.  The Vcenter.Content.Registries.Harbor.GarbageCollection schema contains garbage collection configuration for the Harbor registry.  This schema was added in __vSphere API 7.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | This property is deprecated as of __vSphere API 8.0.1.00200__.  Frequency of garbage collection.  Possible values:   - &#x60;NONE&#x60;: No operation is scheduled.   - &#x60;DAILY&#x60;: An operation occurs on a daily basis.   - &#x60;WEEKLY&#x60;: An operation occurs on a weekly basis.   For more information see: *Vcenter.Content.Registries.Recurrence*.  This property was added in __vSphere API 7.0.0.0__. | 
**DayOfWeek** | **string** | This property is deprecated as of __vSphere API 8.0.1.00200__.  Day of the week when garbage collection should run.  Possible values:   - &#x60;SUNDAY&#x60;: Sunday.   - &#x60;MONDAY&#x60;: Monday.   - &#x60;TUESDAY&#x60;: Tuesday.   - &#x60;WEDNESDAY&#x60;: Wednesday.   - &#x60;THURSDAY&#x60;: Thursday.   - &#x60;FRIDAY&#x60;: Friday.   - &#x60;SATURDAY&#x60;: Saturday.   For more information see: *Vcenter.Content.Registries.DayOfWeek*.  This property was added in __vSphere API 7.0.0.0__.  This property is optional and it is only relevant when the value of type is *Vcenter.Content.Registries.Recurrence.WEEKLY*. | [optional] 
**Hour** | **long** | This property is deprecated as of __vSphere API 8.0.1.00200__.  Hour at which garbage collection should run.  This property was added in __vSphere API 7.0.0.0__.  This property is optional and it is only relevant when the value of type is one of *Vcenter.Content.Registries.Recurrence.DAILY* or *Vcenter.Content.Registries.Recurrence.WEEKLY*. | [optional] 
**Minute** | **long** | This property is deprecated as of __vSphere API 8.0.1.00200__.  Minute at which garbage collection should run.  This property was added in __vSphere API 7.0.0.0__.  This property is optional and it is only relevant when the value of type is one of *Vcenter.Content.Registries.Recurrence.DAILY* or *Vcenter.Content.Registries.Recurrence.WEEKLY*. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

