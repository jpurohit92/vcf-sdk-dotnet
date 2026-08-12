# Vcenter.ViJson.OpenApi.Model.HostProfileHostBasedConfigSpec

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Host** | [**ManagedObjectReference**](ManagedObjectReference.md) | ESX host.  Refers instance of *HostSystem*.  | 
**UseHostProfileEngine** | **bool** | Flag indicating if the Profile Engine should use the profile plug-ins present on the host to create the profile.  If &lt;code&gt;true&lt;/code&gt;, the host Profile Engine uses the vSphere 5.0 (or later) profile plug-ins. The resulting profile is not compatible with legacy hosts (pre 5.0). If &lt;code&gt;false&lt;/code&gt; or not specified, the Profile Engine creates a legacy host profile.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

