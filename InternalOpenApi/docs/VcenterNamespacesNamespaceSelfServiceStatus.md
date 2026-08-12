# Vcenter.Automation.OpenApi.Model.VcenterNamespacesNamespaceSelfServiceStatus
This enumeration is deprecated as of __vSphere API 9.1.0.0__.  The page describes the status of the namespace self-service on the cluster on which vSphere Namespaces enabled.  Possible values:   - `CONFIGURING`: The configuration is being applied to the service.   - `RUNNING`: The namespace self service is configured correctly. The expected transitions: 1. CONFIGURING - -> RUNNING 2. RUNNING - -> CONFIGURING. This transition occurs in the below scenarios: a. When different Dev Users/Groups are empowered with self-service namespace access. b. To reconcile the state of the cluster after the cluster upgrade.   - `REMOVING`: The configuration is being removed and service is being deleted. The expected transitions: 1. CONFIGURING - -> RUNNING - -> REMOVING 2. CONFIGURING - -> REMOVING   - `DEACTIVATED`: The namespace self service is deactivated. This status also represents the initial status of the service before activation. The expected transitions after the service is activated: 1. CONFIGURING - -> RUNNING - -> REMOVING - -> DEACTIVATED 2. CONFIGURING - -> REMOVING - -> DEACTIVATED   - `ERROR`: Failed to apply the configuration to the namespace self-service or unable to deactivate the namespace self-service, user intervention needed. The expected transitions: 1. CONFIGURING - -> ERROR 2. CONFIGURING - -> RUNNING - -> ERROR 3. CONFIGURING - -> RUNNING - -> REMOVING - -> ERROR 4. CONFIGURING - -> REMOVING - -> ERROR The *Vcenter.Namespaces.NamespaceSelfService.Info.messages* field captures the relevant error messages explaining this ERROR status.   This enumeration was added in __vSphere API 7.0.2.00100__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

