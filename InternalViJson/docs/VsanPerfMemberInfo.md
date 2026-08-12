# Vcenter.ViJson.OpenApi.Model.VsanPerfMemberInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Thumbprint** | **string** | SSL certificate thumbprint (SHA1 hash of binary certificate string)  | 
**ThumbprintList** | [**List&lt;VirtualMachineCertThumbprint&gt;**](VirtualMachineCertThumbprint.md) | A list of SSL certificate thumbprints with supported secure hashing algorithms.  See *VirtualMachineCertThumbprint*  | [optional] 
**MemberUuid** | **string** | UUID of the cluster member.  | [optional] 
**IsSupportUnicast** | **bool** | vSAN software format version of the cluster member.  | [optional] 
**UnicastAddressInfos** | [**List&lt;VsanUnicastAddressInfo&gt;**](VsanUnicastAddressInfo.md) | Unicast configuration of the cluster member.  | [optional] 
**Hostname** | **string** | The hostname of the cluster member.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

