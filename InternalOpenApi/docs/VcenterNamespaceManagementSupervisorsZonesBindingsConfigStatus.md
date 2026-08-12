# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementSupervisorsZonesBindingsConfigStatus
The Vcenter.NamespaceManagement.Supervisors.Zones.Bindings.ConfigStatus enumerated type describes the status of configuration for the vSphere Zone binding. When status is different than READY, desired configuration for vSphere Zone has not been realized.  Possible values:   - `CONFIGURING`: New configuration has been detected and is being applied to the vSphere Zone.   - `REMOVING`: The vSphere Zone is being removed.   - `READY`: The vSphere Zone configuration has been applied successfully.   - `ERROR`: Failed to apply the configuration to the vSphere Zone, user intervention may be needed. See vSphere Zone *Vcenter.NamespaceManagement.Supervisors.Zones.Bindings.Info.messages* for more details.   This enumeration was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

