# Vcenter.ViJson.OpenApi.Model.HostNicFailureCriteria

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CheckSpeed** | **string** | Deprecated as of VI API 5.1, this property is not supported.  To use link speed as the criteria, _checkSpeed_ must be one of the following values: - **exact**: Use exact speed to detect link failure.   **speed** is the configured exact speed in megabits per second. - **minimum**: Use minimum speed to detect failure.   **speed** is the configured minimum speed in megabits per second. - **empty string**: Do not use link speed to detect failure.   **speed** is unused in this case.  | [optional] 
**Speed** | **int** | Deprecated as of VI API 5.1, this property is not supported.  Speed.  See also *HostNicFailureCriteria.checkSpeed*.  | [optional] 
**CheckDuplex** | **bool** | Deprecated as of VI API 5.1, this property is not supported.  The flag to indicate whether or not to use the link duplex reported by the driver as link selection criteria.  If **checkDuplex** is true, then fullDuplex is the configured duplex mode. The link is considered bad if the link duplex reported by driver is not the same as fullDuplex.  If **checkDuplex** is false, then fullDuplex is unused, and link duplexity is not used as a detection method.  | [optional] 
**FullDuplex** | **bool** | Deprecated as of VI API 5.1, this property is not supported.  Full duplex.  See also *HostNicFailureCriteria.checkDuplex*.  | [optional] 
**CheckErrorPercent** | **bool** | Deprecated as of VI API 5.1, this property is not supported.  The flag to indicate whether or not to use link error percentage to detect failure.  If **checkErrorPercent** is true, then percentage is the configured error percentage that is tolerated. The link is considered bad if error rate exceeds percentage.  If **checkErrorPercent** is false, percentage is unused, and error percentage is not used as a detection method.  | [optional] 
**Percentage** | **int** | Deprecated as of VI API 5.1, this property is not supported.  Percentage.  See also *HostNicFailureCriteria.checkErrorPercent*.  | [optional] 
**CheckBeacon** | **bool** | The flag to indicate whether or not to enable this property to enable beacon probing as a method to validate the link status of a physical network adapter.  **checkBeacon** can be enabled only if the VirtualSwitch has been configured to use the beacon. Attempting to set **checkBeacon** on a PortGroup or VirtualSwitch that does not have beacon probing configured for the applicable VirtualSwitch results in an error.  See also *HostVirtualSwitchBondBridge.beacon*, *HostVirtualSwitchBeaconConfig*.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

