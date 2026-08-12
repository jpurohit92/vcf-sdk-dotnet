# Vcenter.ViJson.OpenApi.Model.StructuredCustomizations

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Entity** | [**ManagedObjectReference**](ManagedObjectReference.md) | Entity associated with the host customizations specified in the &lt;code&gt;customizations&lt;/code&gt; *AnswerFile* object.  In the current release, this object will always be a host.  Refers instance of *ManagedEntity*.  | 
**Customizations** | [**AnswerFile**](AnswerFile.md) | Host Profile Customizations for the associated &lt;code&gt;entity&lt;/code&gt;.  This is the same object that would be returned by the *HostProfileManager.RetrieveAnswerFile* method  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

