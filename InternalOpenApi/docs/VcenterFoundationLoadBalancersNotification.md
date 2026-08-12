# Vcenter.Automation.OpenApi.Model.VcenterFoundationLoadBalancersNotification
The Vcenter.FoundationLoadBalancers.Notification schema contains properties to describe any info/warning/error messages that the service can raise in deploying/configuring/running the load balancers.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Severity** | **string** | The notification message severity level, this field indicates the severity of current message, user can select their preferred severity level for notifications based on this field.  Possible values:   - &#x60;INFO&#x60;: Info level.   - &#x60;WARNING&#x60;: Warning level.   - &#x60;ERROR&#x60;: Error level.   For more information see: *Vcenter.FoundationLoadBalancers.Notification.Severity*.  This property was added in __vSphere API 9.0.0.0__. | 
**Title** | **string** | Fixed string to indicate the notification&#39;s type.  This property was added in __vSphere API 9.0.0.0__. | 
**Message** | **string** | The content of the notification message.  This property was added in __vSphere API 9.0.0.0__. | 
**Time** | **DateTime** | The generation time of the notification message.  This property was added in __vSphere API 9.0.0.0__.  if missing or &#x60;null&#x60; the notification message doesn&#39;t contain a generation time. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

