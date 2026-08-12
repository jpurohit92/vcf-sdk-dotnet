# Vcenter.ViJson.OpenApi.Model.PbmObjectTypeEnum
The *PbmObjectType_enum* enumerated type defines vSphere Server object types that are known to the Storage Policy Server.  See *PbmServerObjectRef*.*PbmServerObjectRef.objectType*.  Possible values: - `virtualMachine`: Indicates a virtual machine, not including the disks, identified by the virtual machine   identifier _virtual-machine-mor_. - `virtualMachineAndDisks`: Indicates the virtual machine and all its disks, identified by the virtual machine   identifier _virtual-machine-mor_. - `virtualDiskId`: Indicates a virtual disk, identified by disk key   (_virtual-machine-mor_:_disk-key_). - `virtualDiskUUID`: Indicates a virtual disk, identified by UUID - for First Class Storage Object support. - `datastore`: Indicates a datastore. - `vsanObjectId`: Indicates a VSAN object - `fileShareId`: Indicates a file service - `cluster`: Indicates a cluster. - `unknown`: Unknown object type. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

