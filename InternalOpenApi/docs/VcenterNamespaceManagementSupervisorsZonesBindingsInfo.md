# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementSupervisorsZonesBindingsInfo
The Vcenter.NamespaceManagement.Supervisors.Zones.Bindings.Info schema contains the information for a vSphere Zone related to a Supervisor.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Zone** | **string** | Identifier of the vSphere Zone.  This property was added in __vSphere API 9.0.0.0__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.vcenter.consumption_domains.Zone&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.vcenter.consumption_domains.Zone&#x60;. | 
**Type** | **string** | Type of the vSphere Zone.  Possible values:   - &#x60;MANAGEMENT&#x60;: The vSphere Zone is a zone which contains control plane components and workloads.   - &#x60;WORKLOAD&#x60;: The vSphere Zone is a zone which only contains workloads.   For more information see: *Vcenter.NamespaceManagement.Supervisors.Zones.Bindings.Type*.  This property was added in __vSphere API 9.0.0.0__. | 
**Namespaces** | **List&lt;string&gt;** | List of vSphere Namespaces names associated with the vSphere Zone.  This property was added in __vSphere API 9.0.0.0__. | 
**MarkedForRemoval** | **bool** | Indicates if vSphere Zone has been marked for removal.  This property was added in __vSphere API 9.0.0.0__. | 
**Status** | **string** | Indicates vSphere Zone&#39;s configuration status.  Possible values:   - &#x60;CONFIGURING&#x60;: New configuration has been detected and is being applied to the vSphere Zone.   - &#x60;REMOVING&#x60;: The vSphere Zone is being removed.   - &#x60;READY&#x60;: The vSphere Zone configuration has been applied successfully.   - &#x60;ERROR&#x60;: Failed to apply the configuration to the vSphere Zone, user intervention may be needed. See vSphere Zone *Vcenter.NamespaceManagement.Supervisors.Zones.Bindings.Info.messages* for more details.   For more information see: *Vcenter.NamespaceManagement.Supervisors.Zones.Bindings.ConfigStatus*.  This property was added in __vSphere API 9.0.0.0__.  This property is optional because it was added in a newer version than its parent node. | [optional] 
**Messages** | [**List&lt;VcenterNamespaceManagementSupervisorsConditionsMessage&gt;**](VcenterNamespaceManagementSupervisorsConditionsMessage.md) | List of messages populated when the vSphere Zone configuration was not successfully applied.  This property was added in __vSphere API 9.0.0.0__.  This property is optional because it was added in a newer version than its parent node. | [optional] 
**ResourceAllocation** | [**VcenterNamespaceManagementSupervisorsZonesBindingsResourceAllocationInfo**](VcenterNamespaceManagementSupervisorsZonesBindingsResourceAllocationInfo.md) | Desired resource allocations for the vSphere Zone.  This property was added in __vSphere API 9.0.0.0__.  This property is optional because it was added in a newer version than its parent node. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

