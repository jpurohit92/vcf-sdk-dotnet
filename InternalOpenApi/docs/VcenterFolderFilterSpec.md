# Vcenter.Automation.OpenApi.Model.VcenterFolderFilterSpec
The Vcenter.Folder.FilterSpec schema contains properties used to filter the results when listing folders (see *GET /vcenter/folder*). If multiple properties are specified, only folders matching all of the properties match the filter.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | Type that folders must have to match the filter (see *Vcenter.Folder.Summary.type*).  Possible values:   - &#x60;DATACENTER&#x60;: A folder that can contain datacenters.   - &#x60;DATASTORE&#x60;: A folder that can contain datastores.   - &#x60;HOST&#x60;: A folder that can contain compute resources (hosts and clusters).   - &#x60;NETWORK&#x60;: A folder that can contain networkds.   - &#x60;VIRTUAL_MACHINE&#x60;: A folder that can contain virtual machines.   For more information see: *Vcenter.Folder.Type*.  If missing or &#x60;null&#x60;, folders with any type match the filter. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

