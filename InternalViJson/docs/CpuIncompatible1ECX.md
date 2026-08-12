# Vcenter.ViJson.OpenApi.Model.CpuIncompatible1ECX

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Level** | **int** | The CpuIdInfo level where a problem was detected.  Other levels may also have problems.  | 
**RegisterName** | **string** | The CpuIdInfo register where a problem was detected.  Other registers may also have problems. Possible register names are eax, ebx, ecx, or edx.  | 
**RegisterBits** | **string** | The contents of the register on the target host, in CpuIdInfo register format.  The &#39;-&#39; character indicates an unknown value.  | [optional] 
**DesiredBits** | **string** | The desired values for the register&#39;s bits.  The &#39;x&#39; character indicates don&#39;t-care.  | [optional] 
**Host** | [**ManagedObjectReference**](ManagedObjectReference.md) | The host that is not compatible with the requirements.  Refers instance of *HostSystem*.  | [optional] 
**Sse3** | **bool** | Flag to indicate bit 0 is incompatible.  | 
**Pclmulqdq** | **bool** | Flag to indicate bit 1 is incompatible.  | 
**Ssse3** | **bool** | Flag to indicate bit 9 is incompatible.  | 
**Sse41** | **bool** | Flag to indicate bit 19 is incompatible.  | 
**Sse42** | **bool** | Flag to indicate bit 20 is incompatible.  | 
**Aes** | **bool** | Flag to indicate bit 25 is incompatible.  | 
**Other** | **bool** | Flag to indicate that bits other than 0/1/9/19/20/25 are incompatible.  I.e. the detected incompatibilities cannot be completely described by the sse3, pclmulqdq, ssse3, sse41, sse42, and/or aes flags.  | 
**OtherOnly** | **bool** | Flag to indicate that the sse3, pclmulqdq, ssse3, sse41, sse42, and aes flags are all false, and the \&quot;other\&quot; flag is true.  Purely a convenience property for the client processing this fault.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

