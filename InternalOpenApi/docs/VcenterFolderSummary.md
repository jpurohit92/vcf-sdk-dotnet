# Vcenter.Automation.OpenApi.Model.VcenterFolderSummary
The Vcenter.Folder.Summary schema contains commonly used information about a folder.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Folder** | **string** | Identifier of the folder.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;Folder&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;Folder&#x60;. | 
**Name** | **string** | Name of the vCenter Server folder. | 
**Type** | **string** | Type (Type) of the vCenter Server folder.  Possible values:   - &#x60;DATACENTER&#x60;: A folder that can contain datacenters.   - &#x60;DATASTORE&#x60;: A folder that can contain datastores.   - &#x60;HOST&#x60;: A folder that can contain compute resources (hosts and clusters).   - &#x60;NETWORK&#x60;: A folder that can contain networkds.   - &#x60;VIRTUAL_MACHINE&#x60;: A folder that can contain virtual machines.   For more information see: *Vcenter.Folder.Type*. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

