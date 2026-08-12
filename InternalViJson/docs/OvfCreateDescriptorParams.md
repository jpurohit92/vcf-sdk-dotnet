# Vcenter.ViJson.OpenApi.Model.OvfCreateDescriptorParams

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**OvfFiles** | [**List&lt;OvfFile&gt;**](OvfFile.md) | Contains information about the files of the entity, if they have already been downloaded.  Needed to construct the References section of the descriptor.  OvfFile is a positive list of files to include in the export. An Empty list will do no filtering.  | [optional] 
**Name** | **string** | The ovf:id to use for the top-level OVF Entity.  If unset, the entity&#39;s product name is used if available. Otherwise, the VI entity name is used.  | [optional] 
**Description** | **string** | The contents of the Annotation section of the top-level OVF Entity.  If unset, any existing annotation on the entity is left unchanged.  | [optional] 
**IncludeImageFiles** | **bool** | Controls whether attached image files should be included in the descriptor.  This applies to image files attached to VirtualCdrom and VirtualFloppy.  | [optional] 
**ExportOption** | **List&lt;string&gt;** | An optional argument for modifying the export process.  The option is used to control what extra information that will be included in the OVF descriptor.  To get a list of supported keywords see *OvfManager.ovfExportOption*. Unknown options will be ignored by the server.  | [optional] 
**Snapshot** | [**ManagedObjectReference**](ManagedObjectReference.md) | Snapshot reference from which the OVF descriptor should be based.  If this parameter is set, the OVF descriptor is based off the snapshot point. This means that the OVF descriptor will have the same configuration as the virtual machine at the time the snapshot was taken.  The snapshot must be belong to the specified ManagedEntity in the createDescriptor call.  Refers instance of *VirtualMachineSnapshot*.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

