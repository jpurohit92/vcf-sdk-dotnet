# Vcenter.ViJson.OpenApi.Model.DVSFailureCriteria

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Inherited** | **bool** | Whether the configuration is set to inherited value.  | 
**CheckSpeed** | [**StringPolicy**](StringPolicy.md) | To use link speed as the criteria, _checkSpeed_ must be one of the following values: - **exact**: Use exact speed to detect link failure.   **speed** is the configured exact speed in megabits per second. - **minimum**: Use minimum speed to detect failure.   **speed** is the configured minimum speed in megabits per second. - **empty string**: Do not use link speed to detect failure.   **speed** is unused in this case.  | [optional] 
**Speed** | [**IntPolicy**](IntPolicy.md) | See also *DVSFailureCriteria.checkSpeed*.  | [optional] 
**CheckDuplex** | [**BoolPolicy**](BoolPolicy.md) | The flag to indicate whether or not to use the link duplex reported by the driver as link selection criteria.  If **checkDuplex** is true, then fullDuplex is the configured duplex mode. The link is considered bad if the link duplex reported by driver is not the same as fullDuplex.  If **checkDuplex** is false, then fullDuplex is unused, and link duplexity is not used as a detection method.  | [optional] 
**FullDuplex** | [**BoolPolicy**](BoolPolicy.md) | See also *DVSFailureCriteria.checkDuplex*.  | [optional] 
**CheckErrorPercent** | [**BoolPolicy**](BoolPolicy.md) | The flag to indicate whether or not to use link error percentage to detect failure.  If **checkErrorPercent** is true, then percentage is the configured error percentage that is tolerated. The link is considered bad if error rate exceeds percentage.  If **checkErrorPercent** is false, percentage is unused, and error percentage is not used as a detection method.  | [optional] 
**Percentage** | [**IntPolicy**](IntPolicy.md) | See also *DVSFailureCriteria.checkErrorPercent*.  | [optional] 
**CheckBeacon** | [**BoolPolicy**](BoolPolicy.md) | The flag to indicate whether or not to enable this property to enable beacon probing as a method to validate the link status of a physical network adapter.  **checkBeacon** can be enabled only if the VirtualSwitch has been configured to use the beacon. Attempting to set **checkBeacon** on a PortGroup or VirtualSwitch that does not have beacon probing configured for the applicable VirtualSwitch results in an error.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

