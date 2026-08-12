# Vcenter.ViJson.OpenApi.Model.LatencySensitivity

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Level** | **LatencySensitivitySensitivityLevelEnum** | The nominal latency-sensitive level of the application.  | 
**Sensitivity** | **int** | Deprecated as of vSphere version 5.5, this field is deprecated.  The custom absolute latency-sensitivity value of the application.  This value will be used only when the latency-sensitivity *LatencySensitivity.level* property is is set to &lt;code&gt;custom&lt;/code&gt;. It is ignored in all other cases.  The unit of this value is micro-seconds and the application is more latency sensitive when this value is smaller. For example, if the absolute latency-sensitivity is 2000us, the kernel will try to schedule the virtual machine in a way so that its scheduling latency is not more than 2ms.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

