# Vcenter.ViJson.OpenApi.Model.PosixUserSearchResult

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Principal** | **string** | Login name of a user or the name of a group.  This key is the user within the searched domain.  | 
**FullName** | **string** | Full name of the user found by the search, or the description of a group, if available.  | [optional] 
**Group** | **bool** | If this is true, then the result is a group.  If this is false, then the result is a user.  | 
**Id** | **int** | If the search result is for a user, then id refers to User ID.  For a group, the value of Group ID is assigned to id.  | 
**ShellAccess** | **bool** | If the search result is for a user, shellAccess indicates whether shell access has been granted or not.  | [optional] 
**LastPasswordChange** | **long** | The number of days since 1/1/1970, when the password was last changed.  ***Since:*** vSphere API Release 9.1.0.0  | [optional] 
**MaximumPasswordAge** | **long** | The maximum number of days the password is valid.  ***Since:*** vSphere API Release 9.1.0.0  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

