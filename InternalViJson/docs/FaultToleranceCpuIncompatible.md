# Vcenter.ViJson.OpenApi.Model.FaultToleranceCpuIncompatible

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Level** | **int** | The CpuIdInfo level where a problem was detected.  Other levels may also have problems.  | 
**RegisterName** | **string** | The CpuIdInfo register where a problem was detected.  Other registers may also have problems. Possible register names are eax, ebx, ecx, or edx.  | 
**RegisterBits** | **string** | The contents of the register on the target host, in CpuIdInfo register format.  The &#39;-&#39; character indicates an unknown value.  | [optional] 
**DesiredBits** | **string** | The desired values for the register&#39;s bits.  The &#39;x&#39; character indicates don&#39;t-care.  | [optional] 
**Host** | [**ManagedObjectReference**](ManagedObjectReference.md) | The host that is not compatible with the requirements.  Refers instance of *HostSystem*.  | [optional] 
**Model** | **bool** | Flag to indicate CPU model is incompatible.  | 
**Family** | **bool** | Flag to indicate CPU family is incompatible.  | 
**Stepping** | **bool** | Flag to indicate CPU stepping is incompatible.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

