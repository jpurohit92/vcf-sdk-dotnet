# Vcenter.ViJson.OpenApi.Model.UpdateAnswerFileRequestType
The parameters of *HostProfileManager.UpdateAnswerFile_Task*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Host** | [**ManagedObjectReference**](ManagedObjectReference.md) | Host with which the answer file is associated.  Refers instance of *HostSystem*.  | 
**ConfigSpec** | [**AnswerFileCreateSpec**](AnswerFileCreateSpec.md) | Host-specific configuration data. If the configuration specification does not contain any host-specific user input (&lt;code&gt;configSpec&lt;/code&gt;.*AnswerFileOptionsCreateSpec.userInput*), the method does not perform any operation on the answer file.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

