# Vcenter.ViJson.OpenApi.Model.VasaProviderInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Uid** | **string** | Unique identifier  | 
**Name** | **string** | Name  | 
**Description** | **string** | Description of the provider  | [optional] 
**VarVersion** | **string** | Version of the provider  | [optional] 
**Url** | **string** | Provider URL  | 
**Certificate** | **string** | Provider certificate  | [optional] 
**Status** | **string** | The operational state of VASA Provider.  | [optional] 
**StatusFault** | [**MethodFault**](MethodFault.md) | A fault that describes the cause of the current operational status.  | [optional] 
**VasaVersion** | **string** | Supported VASA(vStorage APIs for Storage Awareness) version  | [optional] 
**Namespace** | **string** | Namespace to categorize storage capabilities provided by arrays managed by the provider  | [optional] 
**LastSyncTime** | **string** | Time stamp to indicate when last sync operation was completed successfully.  | [optional] 
**SupportedVendorModelMapping** | [**List&lt;SupportedVendorModelMapping&gt;**](SupportedVendorModelMapping.md) | List containing mapping between the supported vendorID and corresponding modelID  | [optional] 
**SupportedProfile** | **List&lt;string&gt;** | Deprecated as of SMS API 3.0, use *StorageArray.supportedProfile*.  List of supported profiles  | [optional] 
**SupportedProviderProfile** | **List&lt;string&gt;** | List of supported profiles at provider level.  Must be one of the string values from *ProviderProfile_enum*.  | [optional] 
**RelatedStorageArray** | [**List&lt;RelatedStorageArray&gt;**](RelatedStorageArray.md) | List containing mapping between storage arrays reported by the provider and information such as whether the provider is considered active for them.  | [optional] 
**ProviderId** | **string** | Provider identifier reported by the provider which is unique within the provider namespace.  | [optional] 
**CertificateExpiryDate** | **string** | Provider certificate expiry date.  | [optional] 
**CertificateStatus** | **string** | Provider certificate status This field holds values from *VasaProviderCertificateStatus_enum*  | [optional] 
**ServiceLocation** | **string** | Service location for the VASA endpoint that SMS is using to communicate with the provider.  | [optional] 
**NeedsExplicitActivation** | **bool** | Indicates the type of deployment supported by the provider.  If true, it is an active/passive deployment and the provider needs to be activated explicitly using activateProviderEx() VASA API. If false, it is an active/active deployment and provider does not need any explicit activation to respond to VASA calls.  | [optional] 
**MaxBatchSize** | **long** | Maximum number of elements in batch APIs that the VASA Provider can support.  This value is common to all batch APIs supported by the provider. However, for each specific API, the provider may still throw or return *TooMany* fault in which a different value of maxBatchSize can be specified. If the value is not specified (zero) or invalid (negative), client will assume there&#39;s no common limit for the number of elements that can be handled in all batch APIs.  | [optional] 
**RetainVasaProviderCertificate** | **bool** | Indicate whether the provider wants to retain its certificate after bootstrapping.  If true, SMS will not provision a VMCA signed certificate for the provider and all certificate life cycle management workflows are disabled for this provider certificate. If false, SMS will provision a VMCA signed certificate for the provider and all certificate life cycle management workflows are enabled for this provider certificate.  | [optional] 
**ArrayIndependentProvider** | **bool** | Indicates if this provider is independent of arrays.  Default value for this flag is false, which means this provider supports arrays. Arrays will be queried for this provider during sync. If this flag is set to true, arrays will not be synced for this provider and array related API will not be invoked on this provider.  | [optional] 
**Type** | **string** | Type of this VASA provider.  This field will be equal to one of the values of *VpType_enum*.  | [optional] 
**Category** | **string** | This field indicates the category of the provider and will be equal to one of the values of *VpCategory_enum*.  | [optional] 
**Priority** | **int** | Priority level of the provider within a VASA HA group.  For a stand-alone provider which does not participate in VASA HA, this field will be ignored.  The priority value is an integer with valid range from 0 to 255.  | [optional] 
**FailoverGroupId** | **string** | Unique identifier of a VASA HA group.  Providers should report this identifier to utilize HA feature supported by vSphere. Different providers reporting the same &lt;code&gt;failoverGroupId&lt;/code&gt; will be treated as an HA group. Failover/failback will be done within one group.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

