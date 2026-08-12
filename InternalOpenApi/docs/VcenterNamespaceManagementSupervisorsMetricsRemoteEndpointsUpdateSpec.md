# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementSupervisorsMetricsRemoteEndpointsUpdateSpec
The Vcenter.NamespaceManagement.Supervisors.Metrics.RemoteEndpoints.UpdateSpec schema contains the specification required to update the configuration of a remote endpoint configured with the Supervisor.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | A display name to be used for the given remote endpoint.  This property was added in __vSphere API 9.0.0.0__.  If missing or &#x60;null&#x60;, remote endpoint name will not be modified. | [optional] 
**Interval** | **long** | The frequency, in seconds, at which the Supervisor sends metrics to the remote endpoint.  This property was added in __vSphere API 9.0.0.0__.  If missing or &#x60;null&#x60;, interval will not be modified. | [optional] 
**RemoteEndpointType** | **string** | Describes the type of remote endpoint.  Possible values:   - &#x60;HTTP&#x60;: Indicates HTTP/HTTPS based remote endpoint.   For more information see: *Vcenter.NamespaceManagement.Supervisors.Metrics.RemoteEndpointType*.  This property was added in __vSphere API 9.0.0.0__.  If missing or &#x60;null&#x60;, remote endpoint configuration will not be modified. | [optional] 
**HttpRemoteEndpoint** | [**VcenterNamespaceManagementSupervisorsMetricsHttpRemoteEndpointUpdateSpec**](VcenterNamespaceManagementSupervisorsMetricsHttpRemoteEndpointUpdateSpec.md) | Defines the HTTP or HTTPS remote endpoint configuration for Supervisor to send metrics.  This property was added in __vSphere API 9.0.0.0__.  If missing or &#x60;null&#x60;, remote endpoint configuration will not be modified. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

