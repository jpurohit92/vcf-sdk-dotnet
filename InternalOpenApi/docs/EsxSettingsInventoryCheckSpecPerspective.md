# Vcenter.Automation.OpenApi.Model.EsxSettingsInventoryCheckSpecPerspective
The Esx.Settings.Inventory.CheckSpec.Perspective enumerated type defines the different stages or phases within the VCF (VMware Cloud Foundation) upgrade workflow.    Each Perspective value corresponds to a specific stage of the upgrade process. Checks associated with a particular perspective evaluate whether an entity is prepared to advance to that stage. If any check fails, it signifies that the entity is not yet prepared to advance to the corresponding upgrade phase.  Possible values:   - `GENERAL_UPGRADE_READINESS`: Represents the initial readiness evaluation phase. This perspective checks whether the entity meets the required health criteria and passes all relevant eligibility checks to begin the upgrade process.   - `UPGRADE_PLANNING`: Represents the planning phase. This perspective determines upgrade feasibility of the entity to a designated software release. Ensures that entity meets the required health criteria and passes all relevant eligibility checks to upgrade to the specific release.   This enumeration was added in __vSphere API 9.1.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

