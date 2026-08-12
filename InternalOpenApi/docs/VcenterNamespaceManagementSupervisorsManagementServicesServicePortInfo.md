# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementSupervisorsManagementServicesServicePortInfo
The Vcenter.NamespaceManagement.Supervisors.ManagementServices.ServicePortInfo schema specifies a port and protocol for a Management Service.  This schema was added in __vSphere API 9.1.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Name of the service port.  This property was added in __vSphere API 9.1.0.0__. | 
**Port** | **long** | Port number on which the service is exposed.  This property was added in __vSphere API 9.1.0.0__. | 
**TransportProtocol** | **string** | Transport-layer protocol used by the service.  Possible values:   - &#x60;TCP&#x60;: Use if the service port uses TCP protocol.   For more information see: *Vcenter.NamespaceManagement.Supervisors.ManagementServices.TransportProtocol*.  This property was added in __vSphere API 9.1.0.0__. | 
**Tls** | [**VcenterNamespaceManagementSupervisorsManagementServicesTLSConfigurationInfo**](VcenterNamespaceManagementSupervisorsManagementServicesTLSConfigurationInfo.md) | TLS configuration of the Management Service.  This property was added in __vSphere API 9.1.0.0__.  If missing or &#x60;null&#x60;, no information about the Management Service&#39;s TLS configuration will be available to the service&#39;s clients in this Supervisor. If the service exposed on this Management Service&#39;s port uses TLS, the clients are expected to discover the TLS configurations through some other means. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

