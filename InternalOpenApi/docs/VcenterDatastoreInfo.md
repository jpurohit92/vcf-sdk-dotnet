# Vcenter.Automation.OpenApi.Model.VcenterDatastoreInfo
The Vcenter.Datastore.Info schema contains information about a datastore.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Name of the datastore. | 
**Type** | **string** | Type (Type) of the datastore.  Possible values:   - &#x60;VMFS&#x60;: VMware File System (ESX Server only).   - &#x60;NFS&#x60;: Network file system v3 (linux &amp; esx servers only).   - &#x60;NFS41&#x60;: Network file system v4.1 (linux &amp; esx servers only).   - &#x60;CIFS&#x60;: Common Internet File System.   - &#x60;VSAN&#x60;: Virtual SAN (ESX Server only).   - &#x60;VFFS&#x60;: Flash Read Cache (ESX Server only).   - &#x60;VVOL&#x60;: vSphere Virtual Volume (ESX Server only).   For more information see: *Vcenter.Datastore.Type*. | 
**Accessible** | **bool** | Whether or not this datastore is accessible. | 
**FreeSpace** | **long** | Available space of this datastore, in bytes.    The server periodically updates this value.  This property will be missing or &#x60;null&#x60; if the available space of this datastore is not known. | [optional] 
**MultipleHostAccess** | **bool** | Whether or not more than one host in the datacenter has been configured with access to the datastore. | 
**ThinProvisioningSupported** | **bool** | Whether or not the datastore supports thin provisioning on a per file basis. When thin provisioning is used, backing storage is lazily allocated. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

