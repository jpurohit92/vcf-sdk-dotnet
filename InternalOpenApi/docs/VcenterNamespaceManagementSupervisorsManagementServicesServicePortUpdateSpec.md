# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementSupervisorsManagementServicesServicePortUpdateSpec
The Vcenter.NamespaceManagement.Supervisors.ManagementServices.ServicePortUpdateSpec schema specifies the port and protocol for the Management Service being updated.  This schema was added in __vSphere API 9.1.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Name of the service port being updated. The name has DNS Label restrictions as specified in [](https://tools.ietf.org/html/rfc1123): it must be an alphanumeric (a-z and 0-9) string, with a maximum length of 63 characters and with &#39;-&#39; character allowed anywhere except the first or last character.    The name must be unique across all ServicePorts within a single Management Service.    If no existing Service Port by this name exists yet in the Management Service&#39;s ports configuration, the specification given will be treated as a Vcenter.NamespaceManagement.Supervisors.ManagementServices.ServicePortCreateSpec schema. Consequently, all constraints applicable to ServicePortCreateSpec applies as well.  This property was added in __vSphere API 9.1.0.0__. | 
**Port** | **long** | Port number on which the service is exposed.  This property was added in __vSphere API 9.1.0.0__. | 
**TransportProtocol** | **string** | Transport-layer protocol used by the service.  Possible values:   - &#x60;TCP&#x60;: Use if the service port uses TCP protocol.   For more information see: *Vcenter.NamespaceManagement.Supervisors.ManagementServices.TransportProtocol*.  This property was added in __vSphere API 9.1.0.0__. | 
**Tls** | [**VcenterNamespaceManagementSupervisorsManagementServicesTLSConfigurationUpdateSpec**](VcenterNamespaceManagementSupervisorsManagementServicesTLSConfigurationUpdateSpec.md) | TLS configuration of the Management Service.    This configuration may be useful to workloads as a means to discover TLS configurations required to communicate with the Management Service.  This property was added in __vSphere API 9.1.0.0__.  If missing or &#x60;null&#x60;, no information about the Management Service&#39;s TLS configuration will be available to the service&#39;s clients in this Supervisor. If the service exposed on this Management Service&#39;s port uses TLS, the clients are expected to discover the TLS configurations through some other means. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

