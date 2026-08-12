# Vcenter.ViJson.OpenApi.Model.HostVMotionCompatibility

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Host** | [**ManagedObjectReference**](ManagedObjectReference.md) | The prospective host for the virtual machine.  Refers instance of *HostSystem*.  | 
**Compatibility** | **List&lt;string&gt;** | Ways in which the host is compatible with the designated virtual machine that is a candidate for VMotion.  This array will be a subset of the set of VMotionCompatibilityType strings that were input to queryVMotionCompatibility.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

