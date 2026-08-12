# Vcenter.Automation.OpenApi.Model.VcenterTrustedInfrastructureTrustedClustersKmsServicesAppliedConfigFilterSpec
This schema is deprecated as of __vSphere API 8.0.3.0__ and removed in __vSphere API 9.0.0.0__.  The Vcenter.TrustedInfrastructure.TrustedClusters.Kms.ServicesAppliedConfig.FilterSpec schema specifies the matching criteria to be applied when filtering out Vcenter.TrustedInfrastructure.TrustedClusters.Kms.ServicesAppliedConfig.Summary structures from the collection returned by the list method. Only Vcenter.TrustedInfrastructure.TrustedClusters.Kms.ServicesAppliedConfig.Summary structures containing the values specified in this structure will be returned from the list method. If multiple members of the filter spec are set, all of them must match for a result to be filtered out and returned.  This schema was added in __vSphere API 7.0.1.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Health** | **List&lt;string&gt;** | This property is deprecated as of __vSphere API 8.0.3.0__ and removed in __vSphere API 9.0.0.0__.  The health of the applied Key Provider Service configuration.  Possible values:   - &#x60;NONE&#x60;: The consistency of the applied configuration is unknown.   - &#x60;OK&#x60;: The applied Key Provider Service configuration is consistent with the desired state.   - &#x60;ERROR&#x60;: The applied Key Provider Service configuration has diverged from the desired state.   For more information see: *Vcenter.TrustedInfrastructure.TrustedClusters.Kms.ServicesAppliedConfig.Health*.  This property was added in __vSphere API 7.0.1.0__.  If missing or &#x60;null&#x60;, no filtration will be performed by health. | [optional] 
**Address** | [**List&lt;VcenterTrustedInfrastructureNetworkAddress&gt;**](VcenterTrustedInfrastructureNetworkAddress.md) | This property is deprecated as of __vSphere API 8.0.3.0__ and removed in __vSphere API 9.0.0.0__.  The network address of the Key Provider Service configured for use in the Trusted Cluster.  This property was added in __vSphere API 7.0.1.0__.  If missing or &#x60;null&#x60;, no filtration will be performed by network address. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

