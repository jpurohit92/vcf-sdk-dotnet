# Vcenter.ViJson.OpenApi.Model.HostSpecification

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CreatedTime** | **DateTime** | Time at which the host specification was created.  | 
**LastModified** | **DateTime** | Time at which the host specification was last modified.  If it isn&#39;t set, it is the same as &lt;code&gt;createdTime&lt;/code&gt;.  | [optional] 
**Host** | [**ManagedObjectReference**](ManagedObjectReference.md) | The host that the spec data belongs to.  Refers instance of *HostSystem*.  | 
**SubSpecs** | [**List&lt;HostSubSpecification&gt;**](HostSubSpecification.md) | The collection of the host sub specifications.  It is optional.  | [optional] 
**ChangeID** | **string** | The change ID for querying the host specification data updated in a time period.  It has a format of timestamp:change\\_number, where timestamp is the decimal string of a start time, and change\\_number is the decimal string of an auto incremented variable counting from the start time.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

