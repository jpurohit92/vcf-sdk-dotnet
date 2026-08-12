# Vcenter.ViJson.OpenApi.Model.HostUnresolvedVmfsResolutionSpec

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ExtentDevicePath** | **List&lt;string&gt;** | List of device paths each specifying a VMFS extent.  One extent must be specified. This property is represented as a list to enable future enhancements to the interface.  | 
**UuidResolution** | **string** | When set to Resignature, new Uuid is assigned to the VMFS volume.  When set to &#39;forceMount&#39;, existing uuid is assigned to the Vmfs volume and Vmfs volumes metadata doesn&#39;t change.  See also *HostUnresolvedVmfsResolutionSpecVmfsUuidResolution_enum*.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

