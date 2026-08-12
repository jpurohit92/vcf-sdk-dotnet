# Vcenter.ViJson.OpenApi.Model.HostProfileManagerConfigTaskList

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ConfigSpec** | [**HostConfigSpec**](HostConfigSpec.md) | Set of configuration changes to be applied to the host.  | [optional] 
**TaskDescription** | [**List&lt;LocalizableMessage&gt;**](LocalizableMessage.md) | Description of tasks that will be performed on the host to carry out HostProfile application.  | [optional] 
**TaskListRequirement** | **List&lt;string&gt;** | A set of requirements whose actions must be fulfilled before and/or after the task list is applied on an ESXi host, e.g.  whether the ESXi host must be in maintenance mode prior to applying the &lt;code&gt;configSpec&lt;/code&gt;, or whether the host will need to be rebooted after applying the &lt;code&gt;configSpec&lt;/code&gt;. See *HostProfileManagerTaskListRequirement_enum* for details of supported values.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

