Feature: Feature

As a seller, I would like to sign up to MarsQA portal and create my profile
So people seeking for some skills can look into my details.

@tag1
    Scenario:01) Add Education Record on my profile
	Given I launnch and logged into MARSQA portal successfully
	When I add new education record
	Then The new Education Record should be added successfully

	Scenario: 02) Edit education record on my profile
	Given I launnch and logged into MARSQA portal successfully
	When I edited an existing education record
	Then  The new education record should be edited successfully

	Scenario: 03) Delete education record on my profile
	Given I launnch and logged into MARSQA portal successfully
	When I deleted an existing education record
	Then The new education record should be deleted succesfully

	#Scenario: 04) Add language on my profile
#	Given I launch and log into MarsQA portal successfully
#	When I add a new language
#	Then The new language should be added successfully
#
#   Scenario: 05) Edit language on my profile
#	Given I launch and log into MarsQA portal successfully
#	When I edit the last language added
#	Then The last language added should be updated successfully
#
#   Scenario: 06) Delete language on my profile
#	Given I launch and log into MarsQA portal successfully
#	When I delete the last language added
#	Then The last language added should be deleted successfully
#
#   Scenario: 07) Add skills on my profile
#	Given I launch and log into MarsQA portal successfully
#	When I add a new skill
#	Then The new skill should be added successfully
#
#   Scenario: 08) Edit skills on my profile
#	Given I launch and log into MarsQA portal successfully
#	When I edit the last skill added
#	Then The last skill added should be updated successfully
#
#   Scenario: 09) Delete skills on my profile
#	Given I launch and log into MarsQA portal successfully
#	When I delete the last skill added
#	Then The last skill added should be deleted successfully
#
#   Scenario: 08) Add certification details on my profile
#	Given I launch and log into MarsQA portal successfully
#	When I add a new certification details
#	Then The new certification details should be added successfully
#
#   Scenario: 08) Edit certification details on my profile
#	Given I launch and log into MarsQA portal successfully
#	When I edit the last certification record
#	Then The last certification record added should be updated successfully
#
#   Scenario: 09) Delete certification details on my profile
#	Given I launch and log into MarsQA portal successfully
#	When I delete the last certification record
#	Then The last certification record added should be deleted successfully
#
#   Scenario: 10) Add description on my profile
#	Given I launch and log into MarsQA portal successfully
#	When I add a new description
#	Then The new description should be added successfully
#
#   Scenario: 11) Edit description on my profile
#	Given I launch and log into MarsQA portal successfully
#	When I edit the new description added
#	Then The new description added should be updated successfully
#
#   Scenario: 12) Delete description on my profile
#	Given I launch and log into MarsQA portal successfully
#	When I delete the new description added
#	Then The new description added should be deleted successfully
#
#   Scenario: 08) Add Availability type on my profile
#	Given I launch and log into MarsQA portal successfully
#	When I select the availability type 
#	Then The availability type should be displayed successfully
#
#   Scenario: 09) Add Working hours range on my profile
#	Given I launch and log into MarsQA portal successfully
#	When  I select the number of working hours
#	Then The estimated working hours should be displayed successfully
#
#   Scenario: 10) Add Earn target on my profile
#	Given I launch and log into MarsQA portal successfully
#	When I select the earning target range
#	Then The estimated earning target should be displaye successfully

