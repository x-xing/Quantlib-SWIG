/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.12
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package org.quantlib;

public class AmericanExercise extends Exercise {
  private transient long swigCPtr;

  protected AmericanExercise(long cPtr, boolean cMemoryOwn) {
    super(QuantLibJNI.AmericanExercise_SWIGUpcast(cPtr), cMemoryOwn);
    swigCPtr = cPtr;
  }

  protected static long getCPtr(AmericanExercise obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  protected void finalize() {
    delete();
  }

  public synchronized void delete() {
    if (swigCPtr != 0) {
      if (swigCMemOwn) {
        swigCMemOwn = false;
        QuantLibJNI.delete_AmericanExercise(swigCPtr);
      }
      swigCPtr = 0;
    }
    super.delete();
  }

  public AmericanExercise(Date earliestDate, Date latestDate, boolean payoffAtExpiry) {
    this(QuantLibJNI.new_AmericanExercise__SWIG_0(Date.getCPtr(earliestDate), earliestDate, Date.getCPtr(latestDate), latestDate, payoffAtExpiry), true);
  }

  public AmericanExercise(Date earliestDate, Date latestDate) {
    this(QuantLibJNI.new_AmericanExercise__SWIG_1(Date.getCPtr(earliestDate), earliestDate, Date.getCPtr(latestDate), latestDate), true);
  }

}