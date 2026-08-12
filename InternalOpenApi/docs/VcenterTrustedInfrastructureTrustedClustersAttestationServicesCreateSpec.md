# Vcenter.Automation.OpenApi.Model.VcenterTrustedInfrastructureTrustedClustersAttestationServicesCreateSpec
This schema is deprecated as of __vSphere API 8.0.3.0__ and removed in __vSphere API 9.0.0.0__.  The Vcenter.TrustedInfrastructure.TrustedClusters.Attestation.Services.CreateSpec schema contains the data necessary for configuring a registered Attestation Service instance with a cluster in the environment.  This schema was added in __vSphere API 7.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | This property is deprecated as of __vSphere API 8.0.3.0__ and removed in __vSphere API 9.0.0.0__.  Source of truth for the configuration of the Attestation Service.  Possible values:   - &#x60;SERVICE&#x60;: The Attestation Service will be configured based on an ID of an specific Attestation Service.   - &#x60;CLUSTER&#x60;: The Attestation Service will be configured based on an ID of a whole attestation cluster.   For more information see: *Vcenter.TrustedInfrastructure.TrustedClusters.Attestation.Services.CreateSpec.SourceType*.  This property was added in __vSphere API 7.0.0.0__. | 
**Service** | **string** | This property is deprecated as of __vSphere API 8.0.3.0__ and removed in __vSphere API 9.0.0.0__.  The service&#39;s unique ID.  This property was added in __vSphere API 7.0.0.0__.  This property is optional and it is only relevant when the value of type is *Vcenter.TrustedInfrastructure.TrustedClusters.Attestation.Services.CreateSpec.SourceType.SERVICE*.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.vcenter.trusted_infrastructure.attestation.Service&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.vcenter.trusted_infrastructure.attestation.Service&#x60;. | [optional] 
**TrustAuthorityCluster** | **string** | This property is deprecated as of __vSphere API 8.0.3.0__ and removed in __vSphere API 9.0.0.0__.  The attestation cluster&#39;s unique ID.  This property was added in __vSphere API 7.0.0.0__.  This property is optional and it is only relevant when the value of type is *Vcenter.TrustedInfrastructure.TrustedClusters.Attestation.Services.CreateSpec.SourceType.CLUSTER*. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

