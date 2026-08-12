# Vcenter.ViJson.OpenApi.Model.CnsNFSAccessControlSpec

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**NetPermission** | [**VsanFileShareNetPermission**](VsanFileShareNetPermission.md) | The permission settings of users based on the network information.  This setting should include the IP information of the users, permission assigned and the user squash information. The accepted IP formats are: 1\\) Single IP address, e.g., 123.23.23.123; 2\\) IP addresses with subnet mask, e.g., 123.23.23.0/8; 3\\) IP address ranges specified with &#39;-&#39;, e.g., 123.23.23.123-123.23.23.128; 4\\) The string &#39;\\*&#39; implies all clients. Please see *VsanFileShareNetPermission*.    Note that the *VsanFileShareNetPermission.permissions* will be ignored if the delete flag is set.  | 
**Delete** | **bool** | Whether to delete the access control rules.  If set to true, existing rules whose IP is matched will be deleted. If this is not set or set to false, the net permissions will be added to the existing permission list.    Note that 1) To delete rules from the NFS, the input IP has to exactly match the existing rules&#39; IP in string. Otherwise, it will be ignored; 2\\) If there are no rules left after rules being deleted, CNS will add the permission {\\*, NO\\_ACCESS} as the default rule.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

