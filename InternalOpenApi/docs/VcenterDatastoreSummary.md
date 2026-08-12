# Vcenter.Automation.OpenApi.Model.VcenterDatastoreSummary
The Vcenter.Datastore.Summary schema contains commonly used information about a datastore.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Datastore** | **string** | Identifier of the datastore.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;Datastore&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;Datastore&#x60;. | 
**Name** | **string** | Name of the datastore. | 
**Type** | **string** | Type (Type) of the datastore.  Possible values:   - &#x60;VMFS&#x60;: VMware File System (ESX Server only).   - &#x60;NFS&#x60;: Network file system v3 (linux &amp; esx servers only).   - &#x60;NFS41&#x60;: Network file system v4.1 (linux &amp; esx servers only).   - &#x60;CIFS&#x60;: Common Internet File System.   - &#x60;VSAN&#x60;: Virtual SAN (ESX Server only).   - &#x60;VFFS&#x60;: Flash Read Cache (ESX Server only).   - &#x60;VVOL&#x60;: vSphere Virtual Volume (ESX Server only).   For more information see: *Vcenter.Datastore.Type*. | 
**FreeSpace** | **long** | Available space of this datastore, in bytes.    The server periodically updates this value.  This property will be missing or &#x60;null&#x60; if the available space of this datastore is not known. | [optional] 
**Capacity** | **long** | Capacity of this datastore, in bytes.    The server periodically updates this value.  This property will be missing or &#x60;null&#x60; if the capacity of this datastore is not known. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

