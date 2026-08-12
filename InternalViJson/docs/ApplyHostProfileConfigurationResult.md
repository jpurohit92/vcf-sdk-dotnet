# Vcenter.ViJson.OpenApi.Model.ApplyHostProfileConfigurationResult

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**StartTime** | **DateTime** | Time that the host config apply starts.  | 
**CompleteTime** | **DateTime** | Time that the host config apply completes.  | 
**Host** | [**ManagedObjectReference**](ManagedObjectReference.md) | Host to be remediated.  Refers instance of *HostSystem*.  | 
**Status** | **string** | Status of the remediation.  See *ApplyHostProfileConfigurationResultStatus_enum* for valid values.  | 
**Errors** | [**List&lt;MethodFault&gt;**](MethodFault.md) | If &lt;code&gt;status&lt;/code&gt; is &lt;code&gt;fail&lt;/code&gt;, this property contains a list of status error message objects.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

