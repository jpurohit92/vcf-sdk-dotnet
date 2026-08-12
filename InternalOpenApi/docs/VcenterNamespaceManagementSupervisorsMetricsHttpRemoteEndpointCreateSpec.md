# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementSupervisorsMetricsHttpRemoteEndpointCreateSpec
The Vcenter.NamespaceManagement.Supervisors.Metrics.HttpRemoteEndpointCreateSpec schema is used for configuring the Supervisor to send metrics to a remote endpoint in a HTTP message.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Url** | **string** | URL of the remote endpoint where Supervisor should send metrics. This can be an HTTP or HTTPS URL, following the format http(s)://server.com/path/to/metrics.  This property was added in __vSphere API 9.0.0.0__. | 
**TlsClientConfig** | [**VcenterNamespaceManagementSupervisorsMetricsTlsClientConfigCreateSpec**](VcenterNamespaceManagementSupervisorsMetricsTlsClientConfigCreateSpec.md) | TLS client configuration information used by Supervisor for sending metrics to a remote endpoint.  This property was added in __vSphere API 9.0.0.0__.  If missing or &#x60;null&#x60;, Supervisor will not use TLS communication with the remote endpoint when sending metrics. | [optional] 
**HttpHeaders** | [**List&lt;VcenterNamespaceManagementSupervisorsMetricsHttpHeader&gt;**](VcenterNamespaceManagementSupervisorsMetricsHttpHeader.md) | HTTP headers to be added when the Supervisor sends metrics to the remote endpoint.  This property was added in __vSphere API 9.0.0.0__.  If missing or &#x60;null&#x60;, no HTTP headers will be added when sending metrics to the remote endpoint. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

