/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.12
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package org.quantlib;

public class DayCounter {
  private transient long swigCPtr;
  protected transient boolean swigCMemOwn;

  protected DayCounter(long cPtr, boolean cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = cPtr;
  }

  protected static long getCPtr(DayCounter obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  protected void finalize() {
    delete();
  }

  public synchronized void delete() {
    if (swigCPtr != 0) {
      if (swigCMemOwn) {
        swigCMemOwn = false;
        QuantLibJNI.delete_DayCounter(swigCPtr);
      }
      swigCPtr = 0;
    }
  }

  public int dayCount(Date d1, Date d2) {
    return QuantLibJNI.DayCounter_dayCount(swigCPtr, this, Date.getCPtr(d1), d1, Date.getCPtr(d2), d2);
  }

  public double yearFraction(Date d1, Date d2, Date startRef, Date endRef) {
    return QuantLibJNI.DayCounter_yearFraction__SWIG_0(swigCPtr, this, Date.getCPtr(d1), d1, Date.getCPtr(d2), d2, Date.getCPtr(startRef), startRef, Date.getCPtr(endRef), endRef);
  }

  public double yearFraction(Date d1, Date d2, Date startRef) {
    return QuantLibJNI.DayCounter_yearFraction__SWIG_1(swigCPtr, this, Date.getCPtr(d1), d1, Date.getCPtr(d2), d2, Date.getCPtr(startRef), startRef);
  }

  public double yearFraction(Date d1, Date d2) {
    return QuantLibJNI.DayCounter_yearFraction__SWIG_2(swigCPtr, this, Date.getCPtr(d1), d1, Date.getCPtr(d2), d2);
  }

  public String name() {
    return QuantLibJNI.DayCounter_name(swigCPtr, this);
  }

  public String toString() {
    return QuantLibJNI.DayCounter_toString(swigCPtr, this);
  }

  public boolean equals(DayCounter other) {
    return QuantLibJNI.DayCounter_equals(swigCPtr, this, DayCounter.getCPtr(other), other);
  }

  public boolean unEquals(DayCounter other) {
    return QuantLibJNI.DayCounter_unEquals(swigCPtr, this, DayCounter.getCPtr(other), other);
  }

}
