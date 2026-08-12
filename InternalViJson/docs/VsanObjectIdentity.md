# Vcenter.ViJson.OpenApi.Model.VsanObjectIdentity

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Uuid** | **string** | The unique identifier for the object.  It&#39;s vSAN UUID for the vSAN object or the CNS volume ID if it&#39;s CNS object deploying in vSAN direct storage.  | 
**Type** | **string** | Can be one of: &#39;vmswap&#39;, &#39;vdisk&#39;, &#39;namespace&#39;, &#39;vmem&#39;, &#39;stats&#39;, &#39;other&#39;, &#39;iscsiHome&#39;, &#39;iscsiLun&#39;, &#39;iscsiTarget&#39; and &#39;fileShare&#39;.  | 
**VmInstanceUuid** | **string** | Instance UUID of the VM this object belongs to  | [optional] 
**VmNsObjectUuid** | **string** | Name space object UUID of the VM this object belongs to  | [optional] 
**Vm** | [**ManagedObjectReference**](ManagedObjectReference.md) | Reference to VM this object belongs to.  If the API was executed against a host (even if proxied through vCenter) the VM reference will use the MoRef of the host, not that of vCenter. The vmInstanceUuid should be used instead to match to the vCenter MoRef in such cases.  Refers instance of *VirtualMachine*.  | [optional] 
**Description** | **string** | Description  | [optional] 
**SpbmProfileUuid** | **string** | UUID of SPBM profile used for the policy of the object when it was applied to vSAN Object.  Not set if the object doesn&#39;t use an SPBM managed policy.  | [optional] 
**Metadatas** | [**List&lt;KeyValue&gt;**](KeyValue.md) | Metadata for the object identity to describe the additional attributes  | [optional] 
**TypeExtId** | **string** | The vSAN extension object type id.  The extension object type will be created by any of persistency service building on top of vSAN  | [optional] 
**SpbmProfileName** | **string** | Name of SPBM profile used for the policy of the object when it was applied to vSAN Object.  Not set if the object doesn&#39;t use an SPBM managed policy.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

