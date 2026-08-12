# Vcenter.ViJson.OpenApi.Model.RetrieveUserGroupsRequestType
The parameters of *UserDirectory.RetrieveUserGroups*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Domain** | **string** | Domain to be searched. If not set, then the method searches the local machine.  | [optional] 
**SearchStr** | **string** | Case insensitive substring used to filter results; the search string is compared to the login and full name for users, and the name and description for groups. Leave this blank to match all users.  | 
**BelongsToGroup** | **string** | If present, the returned list contains only users or groups that directly belong to the specified group. Users or groups that have indirect membership will not be included in the list.  | [optional] 
**BelongsToUser** | **string** | If present, the returned list contains only groups that directly contain the specified user. Groups that indirectly contain the user will not be included in the list.  | [optional] 
**ExactMatch** | **bool** | Indicates the searchStr passed should match a user or group name exactly.  | 
**FindUsers** | **bool** | True, if users should be included in the result.  | 
**FindGroups** | **bool** | True, if groups should be included in the result.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

