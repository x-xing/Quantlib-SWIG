/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.12
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package org.quantlib;

public final class JointCalendarRule {
  public final static JointCalendarRule JoinHolidays = new JointCalendarRule("JoinHolidays");
  public final static JointCalendarRule JoinBusinessDays = new JointCalendarRule("JoinBusinessDays");

  public final int swigValue() {
    return swigValue;
  }

  public String toString() {
    return swigName;
  }

  public static JointCalendarRule swigToEnum(int swigValue) {
    if (swigValue < swigValues.length && swigValue >= 0 && swigValues[swigValue].swigValue == swigValue)
      return swigValues[swigValue];
    for (int i = 0; i < swigValues.length; i++)
      if (swigValues[i].swigValue == swigValue)
        return swigValues[i];
    throw new IllegalArgumentException("No enum " + JointCalendarRule.class + " with value " + swigValue);
  }

  private JointCalendarRule(String swigName) {
    this.swigName = swigName;
    this.swigValue = swigNext++;
  }

  private JointCalendarRule(String swigName, int swigValue) {
    this.swigName = swigName;
    this.swigValue = swigValue;
    swigNext = swigValue+1;
  }

  private JointCalendarRule(String swigName, JointCalendarRule swigEnum) {
    this.swigName = swigName;
    this.swigValue = swigEnum.swigValue;
    swigNext = this.swigValue+1;
  }

  private static JointCalendarRule[] swigValues = { JoinHolidays, JoinBusinessDays };
  private static int swigNext = 0;
  private final int swigValue;
  private final String swigName;
}
