# Vcenter.ViJson.OpenApi.Model.FaultDomainInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | ID of the fault domain.  | 
**Name** | **string** | Name of the fault domain, if not specified, the id will be used in place of the name.  Name need not be unique.  | [optional] 
**Description** | **string** | Description - could be a localized string.  | [optional] 
**StorageArrayId** | **string** | Identifier of the Storage Array that this Fault Domain belongs to.  A Fault Domain and all its children should report same *FaultDomainInfo.storageArrayId*. It can be left unspecified. If not specified, vSphere will not support High Availability feature for this Fault Domain. When specified, vSphere will treat the the currently active VASA provider for *StorageArray* as the active VASA provider for this Fault Domain and its children. Changing High Availability support choice for a Fault Domain intermittently, by sometimes specifying the storageArrayId and sometimes not, will cause unexpected result and might cause VP to be in &#39;syncError&#39; state in vSphere.  | [optional] 
**Children** | [**List&lt;FaultDomainId&gt;**](FaultDomainId.md) | List of children, the entries in the array should always be *FaultDomainId* and not *FaultDomainInfo*.  The 2016 vSphere release will not support nested Fault Domains. The field FaultDomainInfo#children is ignored by vSphere 2016 release.  | [optional] 
**Provider** | [**ManagedObjectReference**](ManagedObjectReference.md) | VASA provider that is actively managing this fault domain  Refers instance of *SmsProvider*.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

