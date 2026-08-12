# Vcenter.ViJson.OpenApi.Model.AnswerFileStatusResult

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CheckedTime** | **DateTime** | Time that the answer file status was determined.  | 
**Host** | [**ManagedObjectReference**](ManagedObjectReference.md) | Host associated with the answer file.  Refers instance of *HostSystem*.  | 
**Status** | **string** | Status of the answer file.  See *HostProfileManagerAnswerFileStatus_enum* for valid values.  | 
**Error** | [**List&lt;AnswerFileStatusError&gt;**](AnswerFileStatusError.md) | If &lt;code&gt;status&lt;/code&gt; is &lt;code&gt;invalid&lt;/code&gt;, this property contains a list of status error objects.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

