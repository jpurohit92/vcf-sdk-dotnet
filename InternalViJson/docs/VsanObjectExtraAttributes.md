# Vcenter.ViJson.OpenApi.Model.VsanObjectExtraAttributes

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Uuid** | **string** | vSAN object UUID.  | 
**ObjPath** | **string** | vSAN object path.  e.g. /vmfs/volumes/vsan:52cc5b8f6c993df7-09d4123399c5b741/917e495d-166d-bfd0-34c1-020064ae18bb/hbrdisk.RDID-af365505-fed7-4b65-aa3d-7bfe764c257f.20.132464144063983.vmdk  | 
**ObjClass** | **int** | vSAN object class.  The object class and its integer value is defined in objlib. The mapping relationships between value and object type are listed below. - 1 - OBJTYPE\\_CLASS\\_VDISK - 2 - OBJTYPE\\_CLASS\\_SNAPSHOT - 3 - OBJTYPE\\_CLASS\\_VMNAMESPACE - 4 - OBJTYPE\\_CLASS\\_VMSWAP - 5 - OBJTYPE\\_CLASS\\_GENERIC - 6 - OBJTYPE\\_CLASS\\_VMEM - 7 - OBJTYPE\\_CLASS\\_DIGEST - 8 - OBJTYPE\\_CLASS\\_SIDECAR - 9 - OBJTYPE\\_CLASS\\_HBRPERSIST  | 
**Ufn** | **string** | vSAN object ufn (User friendly name).  | 
**IsHbrCfg** | **bool** | Whether this vSAN object is the hbrCfg (HBR CFGFILE) object.  | 
**OwnerClusterUuid** | **string** | Owner cluster UUID for this object.  It is only set for the VM namespace objects. It shows the UUID for the cluster on which this VM is created/registered.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

