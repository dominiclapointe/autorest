/**
 * Copyright (c) Microsoft Corporation. All rights reserved.
 * Licensed under the MIT License. See License.txt in the project root for
 * license information.
 *
 * Code generated by Microsoft (R) AutoRest Code Generator.
 * Changes may cause incorrect behavior and will be lost if the code is
 * regenerated.
 */

package fixtures.bodycomplex.models;


/**
 * The Basic model.
 */
public class Basic {
    /**
     * The id property.
     */
    private Integer id;

    /**
     * The name property.
     */
    private String name;

    /**
     * Possible values include: 'cyan', 'Magenta', 'YELLOW', 'blacK'.
     */
    private String color;

    /**
     * Get the id value.
     *
     * @return the id value
     */
    public Integer id() {
        return this.id;
    }

    /**
     * Set the id value.
     *
     * @param id the id value to set
     * @return the Basic object itself.
     */
    public Basic withId(Integer id) {
        this.id = id;
        return this;
    }

    /**
     * Get the name value.
     *
     * @return the name value
     */
    public String name() {
        return this.name;
    }

    /**
     * Set the name value.
     *
     * @param name the name value to set
     * @return the Basic object itself.
     */
    public Basic withName(String name) {
        this.name = name;
        return this;
    }

    /**
     * Get the color value.
     *
     * @return the color value
     */
    public String color() {
        return this.color;
    }

    /**
     * Set the color value.
     *
     * @param color the color value to set
     * @return the Basic object itself.
     */
    public Basic withColor(String color) {
        this.color = color;
        return this;
    }

}